using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int x, y, sX, sY, cX, cY;


        public PaintSuperForm()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 600;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;


        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            py = e.Location;

            cX = e.X; 
            cY = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pen = new Pen(Barvicka, BrushSize);
            if(drawing == true)
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

            sX = e.X - cX;
            sY = e.Y - cY;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;

            sX = x - cX;
            sY = y - cY;

            switch(drawingtool)
            {
                case Drawingtool.ellipse:
                    g.DrawEllipse(pen, cX, cY, sX, sY);
                    break;

                case Drawingtool.rectangle:
                    g.DrawRectangle(pen, cX, cY, sX, sY);
                    break;

                case Drawingtool.line:
                    g.DrawLine(pen, cX, cY, x, y); 
                    break;
            }
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {

        }

        private void Load_Button_Click(object sender, EventArgs e)
        {

        }

        private void Line_Tool_Button_Click(object sender, EventArgs e)
        {
            drawingtool = Drawingtool.line;
        }
        private void Pen_Tool_Button_Click(object sender, EventArgs e)
        {
            drawingtool = Drawingtool.pen;
        }
        private void Circle_Tool_Button_Click(object sender, EventArgs e)
        {
            drawingtool = Drawingtool.circle;
        }

        private void Rectangle_Tool_Button_Click(object sender, EventArgs e)
        {
            drawingtool = Drawingtool.rectangle;
        }

        private void Ellipse_Tool_Button_Click(object sender, EventArgs e)
        {
            drawingtool = Drawingtool.ellipse;
        }

        private void Color_Button_Click(object sender, EventArgs e)
        {

        }

        private void PaintSuperForm_Load(object sender, EventArgs e)
        {

        }

        private void Eraser_Button_Click(object sender, EventArgs e)
        {
            drawingtool = Drawingtool.eraser;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
