using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class PaintSuperForm : Form
    {
        //defining variables
        private enum Drawingtool
        {
            pen,
            rectangle,
            circle,
            ellipse,
            line,
            eraser,
            polygon
        }
        private ColorDialog colordialog = new ColorDialog();
        private Color Color = Color.Black;
        private int BrushSize = 3;
        private Drawingtool drawingtool;
        private bool drawing = false;
        private int i = 1;
        private Bitmap bitmap;
        private Graphics gdraw;
        private Point px, py;
        private Pen pen;
        private Pen eraser = new Pen(Color.White, 50);
        private int x, y, xsize, ysize, xinitial, yinitial, circlesize;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Graphics g;
        private bool firstdialog = true;
        private bool dirtydocument = false;
        private Stack<Bitmap> Undostack;
        private Stack<Bitmap> Redostack;
        private bool justUndone = false;
        //initializing form components
        public PaintSuperForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        //inittializes live variables
        public void InitializeCustomComponents()
        {
            this.Width = 900;
            this.Height = 600;

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gdraw = Graphics.FromImage(bitmap);
            gdraw.Clear(Color.White);
            pictureBox1.Image = bitmap;

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "save";
            Undostack = new Stack<Bitmap>();
            Redostack = new Stack<Bitmap>();
            SaveState();
        }
        //mouse down handles rising edge logic
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            SaveState();
            Redostack.Clear();
            drawing = true;
            py = e.Location;

            xinitial = e.X;
            yinitial = e.Y;
            xsize = 0;
            ysize = 0;
            dirtydocument = true;
        }
        //mouse move handles continous logic
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pen = new Pen(Color, BrushSize);
            if (drawing == true)
            {
                switch (drawingtool)
                {
                    case Drawingtool.pen:
                        px = e.Location;
                        gdraw.DrawLine(pen, px, py);
                        py = px;
                        break;

                    case Drawingtool.eraser:
                        px = e.Location;
                        gdraw.DrawLine(eraser, px, py);
                        py = px;
                        break;
                }
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;

            xsize = e.X - xinitial;
            ysize = e.Y - yinitial;
        }
        //mouse up handles falling edge logic
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pen = new Pen(Color, BrushSize);
            xsize = x - xinitial;
            ysize = y - yinitial;

            g = Graphics.FromImage(bitmap);
            drawinglogic(g);
            drawing = false;
        }
        
        //saves bitmap to jpeg format
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (firstdialog == true)
            {
                if (pictureBox1.Image != null)
                {
                    saveFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|All Files|*.*";
                    saveFileDialog.FileName = "image.jpg";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        firstdialog = false;
                    }
                }
            }
                Bitmap tempbitmap = bitmap;
                tempbitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                dirtydocument = false;
        }
        //loads jpeg into picture box
        private void Load_Button_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|All Files|*.*";
            openFileDialog.FileName = "image.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog.FileName);
                gdraw = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
        }
        //handles tool previews
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            drawinglogic(g);
        }
        private void drawinglogic(Graphics g)
        {
            if (drawing == true)
            { 
                switch (drawingtool)
                {
                    case Drawingtool.rectangle:
                        g.DrawPolygon(pen, new Point[] { new Point(xinitial, yinitial), new Point(x, yinitial), new Point(x, y), new Point(xinitial, y) });
                        break;
                    case Drawingtool.ellipse:
                        g.DrawEllipse(pen, xinitial, yinitial, xsize, ysize);
                        break;
                    case Drawingtool.line:
                        g.DrawLine(pen, xinitial, yinitial, x, y);
                        break;
                    case Drawingtool.circle:
                        circlesize = xsize;
                        g.DrawEllipse(pen, xinitial, yinitial, circlesize, circlesize);
                        break;
                    case Drawingtool.polygon:
                        Point[] points = new Point[5];
                        points[0] = new Point(xinitial + xsize / 2, yinitial);
                        points[1] = new Point(xinitial + xsize, yinitial + ysize / 3);
                        points[2] = new Point(xinitial + xsize * 2 / 3, yinitial + ysize);
                        points[3] = new Point(xinitial + xsize / 3, yinitial + ysize);
                        points[4] = new Point(xinitial, yinitial + ysize / 3);
                        g.DrawPolygon(pen, points);
                        break;
                }
            }
        }
        private void Line_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.line;
        private void Polygon_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.polygon;

        private void PaintSuperForm_Load(object sender, EventArgs e)
        {

        }

        private void PaintSuperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dirtydocument)
            {
                if (MessageBox.Show("Do you want to save the image?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Save_Button_Click(sender, e);
                }
            }
        }

        private void Undo_Button_Click(object sender, EventArgs e)
        {
            if (Undostack.Count > 1)
            {
                Bitmap current = Undostack.Pop();
                Redostack.Push(bitmap);
                bitmap = current;
                gdraw = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
            else
            {
                MessageBox.Show("No more undos");
            }
        }

        private void Redo_Button_Click(object sender, EventArgs e)
        {
            if(Redostack.Count > 0)
            {
                Bitmap current = Redostack.Pop();
                Undostack.Push(bitmap);
                bitmap = current;
                gdraw = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
            else
            {
                MessageBox.Show("No more redos");
            }
        }

        private void SaveState()
        {
            Undostack.Push((Bitmap)bitmap.Clone());
        }

        private void Pen_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.pen;
        private void Rectangle_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.rectangle;
        private void Ellipse_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.ellipse;
        private void Color_Button_Click(object sender, EventArgs e)
        {
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                Color = colordialog.Color;
            }
        }
        private void Eraser_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.eraser;
        private void Circle_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.circle;
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            gdraw.Clear(Color.White);
            pictureBox1.Image = bitmap;
            firstdialog = true;
        }
    }
}