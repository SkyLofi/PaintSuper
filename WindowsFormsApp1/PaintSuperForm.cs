using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PaintSuperForm : Form
    {
        enum Drawingtool
        {
            pen,
            rectangle,
            circle,
            ellipse,
            line,
            eraser
        }
        ColorDialog colorDialog = new ColorDialog();
        Color Barvicka = Color.Black;
        int BrushSize = 1;
        Drawingtool drawingtool;
        bool drawing = false;
        int i = 1;
        Bitmap bm;
        Graphics g;
        Point px, py;
        Pen pen;
        Pen eraser = new Pen(Color.White, 50);
        int x, y, xsize, ysize, xinitial, yinitial;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        public PaintSuperForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        public void InitializeCustomComponents()
        {
            this.Width = 900;
            this.Height = 600;

            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            py = e.Location;

            xinitial = e.X;
            yinitial = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pen = new Pen(Barvicka, BrushSize);
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
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            pen = new Pen(Barvicka, BrushSize);
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
            }
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                saveFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|All Files|*.*";
                saveFileDialog.FileName = "image.jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bm.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }
        private void Load_Button_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = bm;
            }
        }

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
                }
            }
        }
        private void Line_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.line;
        private void Pen_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.pen;
        private void Rectangle_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.rectangle;
        private void Ellipse_Tool_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.ellipse;
        private void Color_Button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Barvicka = colorDialog.Color;
            }
        }
        private void Eraser_Button_Click(object sender, EventArgs e) => drawingtool = Drawingtool.eraser;    }
}
