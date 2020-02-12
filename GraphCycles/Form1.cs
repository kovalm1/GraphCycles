using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCycles
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            InitGraph();
        }

        void InitGraph()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            picture.Image = bmp;
            g = Graphics.FromImage(picture.Image);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red);
            for (int y = 0; y <= 600; y += 20)
            {
                DrawLine(0, y, 600, y);
            }

        }
        void DrawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
            picture.Refresh();
            Thread.Sleep(10);
        }
        void DrawRect(int x, int y, int w, int h)
        {
            g.DrawRectangle(pen, new Rectangle(x, y, w, h));
            picture.Refresh();
            Thread.Sleep(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picture.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black);
            for (int x = 0; x <= 600; x += 20)
            {
                DrawLine(x, 0, x, 600);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.DarkSalmon);
            for (int a = 0; a <= 600; a += 20)
            {
                DrawLine(a, 0, 0, a);
            }
            for (int a = 0; a <= 600; a += 20)
            {
                DrawLine(a, 600, 600, a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Maroon);
            for (int b = 0; b <= 600; b += 20)
            {
                DrawLine(0, 600, b, 0);
            }
            for (int b = 0; b <= 600; b += 20)
            {
                DrawLine(0, 600, 600, b);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.OliveDrab);
            for (int c = 0; c <= 600; c += 20)
            {
                DrawLine(600, 600, 0, c);
            }
            for (int c = 0; c <= 600; c += 20)
            {
                DrawLine(600, 600, c, 0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int size = 50;
            pen = new Pen(Color.LimeGreen);
            for (int f = 0; f <= 600; f += size)
            {
                for (int d = 0; d <= 600; d += size)
                {
                    DrawRect(d, f, size, size);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int size = 50;
            pen = new Pen(Color.LimeGreen);
            for (int f = 0; f < 600; f += size)
            {
                for (int d = 0; d < 600; d += size)
                {
                    DrawRect(d, f, size, size);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int size = 40;
            pen = new Pen(Color.LimeGreen);
            for (int f = 0; f < 600; f += 50)
            {
                for (int d = 0; d < 600; d += 50)
                {
                    DrawRect(f + 5, d + 5, size, size);

                    for (int a = 0; a < size; a += 5)
                    {
                        DrawLine(f + 5 + a, d + 5 + 0, f + 5 + 0, d + 5 + a);
                    }

                    for (int a = 0; a < size; a += 5)
                    {
                        DrawLine(f + 5 + a, d + 5 + size, f + 5 + size, d + 5 + a);
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int size = 40;
            pen = new Pen(Color.MediumPurple);

            for (int f = 0; f < 600; f += 50)
            {
                for (int d = 0; d < 600; d += 50)
                {
                    DrawRect(f + 5, d + 5, size, size);
                    for (int zf = 0; zf < size; zf += 10)
                    {
                        for (int zd = 0; zd < size; zd += 10)
                        {
                            g.DrawEllipse(pen, f + 5 + zf, d + zd + 5, 10, 10);
                        }
                    }
                }
            }
            picture.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Plum);
            float x1, x2, y1, y2;

            x1 = 300 + 300;
            y1 = 300;

            for (float alfa = 0; alfa <= 2 * Math.PI; alfa += 0.01f)
            {

                x2 = (float)Math.Cos(alfa) * 300 + 300;
                y2 = (float)Math.Sin(alfa) * 300 + 300;

                g.DrawLine(pen, x1, y1, x2, y2);
                picture.Refresh();
                Thread.Sleep(10);
                x1 = x2;
                y1 = y2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red);
            float x1, x2, y1, y2;

            x1 = 300;
            y1 = 300;

            for (float alfa = 0; alfa <= 10 * Math.PI; alfa += 0.01f)
            {

                x2 = (float)Math.Cos(alfa) * alfa * 10 + 300;
                y2 = (float)Math.Sin(alfa) * alfa * 10 + 300;

                g.DrawLine(pen, x1, y1, x2, y2);
                picture.Refresh();
                Thread.Sleep(2);
                x1 = x2;
                y1 = y2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black);
            Pen w = new Pen(Color.White);
            for (int coeff = 1; coeff <= 360; coeff++)
            {
                for (int i = 0; i < 360; i++)
                {
                    ArcLine(w, i, i * (coeff - 1));
                    ArcLine(p, i, i * coeff);
                }
            }
        }

        void ArcLine(Pen pen, float alfa, float beta)
        {
            float x1 = (float)Math.Cos(alfa / 180 * Math.PI) * 300 + 300;
            float y1 = (float)Math.Sin(alfa / 180 * Math.PI) * 300 + 300;

            float x2 = (float)Math.Cos(beta / 180 * Math.PI) * 300 + 300;
            float y2 = (float)Math.Sin(beta / 180 * Math.PI) * 300 + 300;

            g.DrawLine(pen, x1, y1, x2, y2);
            picture.Refresh();
        }
    }
}