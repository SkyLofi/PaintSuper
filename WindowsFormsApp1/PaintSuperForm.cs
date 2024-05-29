using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PaintSuperForm : Form
    {
        //defining variables
        enum Drawingtool
        {
            pen,
            rectangle,
            circle,
            ellipse,
            line,
            eraser
        }
        ColorDialog colordialog = new ColorDialog();
        Color Color = Color.Black;
        int BrushSize = 3;
        Drawingtool drawingtool;
        bool drawing = false;
        int i = 1;
        Bitmap bitmap;
        Graphics g;
        Point px, py;
        Pen pen;
        Pen eraser = new Pen(Color.White, 50);
        int x, y, xsize, ysize, xinitial, yinitial, circlesize;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;

        //initializing form components
        public PaintSuperForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        public void InitializeCustomComponents()        //inittializes live variables
        {
            this.Width = 900;
            this.Height = 600;

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }
        //mouse down hadles rising edge logic
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            g = Graphics.FromImage(bitmap);
            drawing = true;
            py = e.Location;

            xinitial = e.X;
            yinitial = e.Y;
        }
        //mouse move handles continous logic
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            g = Graphics.FromImage(bitmap);
            pen = new Pen(Color, BrushSize);
            if (drawing == true)
            {
                switch (drawingtool)
                {
                    case Drawingtool.pen:
                        px = e.Location;
                        g.DrawLine(pen, px, py);
                        py = px;
                        break;

                    case Drawingtool.eraser:
                        px = e.Location;
                        g.DrawLine(eraser, px, py);
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
            g = Graphics.FromImage(bitmap);
            drawing = false;
            pen = new Pen(Color, BrushSize);
            xsize = x - xinitial;
            ysize = y - yinitial;

            switch (drawingtool)
            {
                case Drawingtool.ellipse:
                    g.DrawEllipse(pen, xinitial, yinitial, xsize, ysize);
                    break;

                case Drawingtool.rectangle:
                    g.DrawRectangle(pen, xinitial, yinitial, xsize, ysize);
                    break;

                case Drawingtool.line:
                    g.DrawLine(pen, xinitial, yinitial, x, y);
                    break;

                case Drawingtool.circle:
                    circlesize = xsize;
                    g.DrawEllipse(pen, xinitial, yinitial, circlesize, circlesize);
                    break;
            }
        }
        //saves bitmap to jpeg format
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                saveFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|All Files|*.*";
                saveFileDialog.FileName = "image.jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap tempbitmap = bitmap;
                    tempbitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }
        //loads jpeg into picture box
        private void Load_Button_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = bitmap;
            }
        }
        //handles tool previews
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gdraw = e.Graphics;
            if (drawing == true)
            {
                switch (drawingtool)
                {
                    case Drawingtool.ellipse:
                        gdraw.DrawEllipse(pen, xinitial, yinitial, xsize, ysize);
                        break;

                    case Drawingtool.rectangle:
                        gdraw.DrawRectangle(pen, xinitial, yinitial, xsize, ysize);
                        break;

                    case Drawingtool.line:
                        gdraw.DrawLine(pen, xinitial, yinitial, x, y);
                        break;

                    case Drawingtool.circle:
                        circlesize = xsize;
                        gdraw.DrawEllipse(pen, xinitial, yinitial, circlesize, circlesize);
                        break;
                }
            }
        }
        private void Line_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.line;
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
        private void Circle_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.circle;
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }
    }
}