using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factoring
{
    public partial class Form1 : Form
    {

        private Pen black;
        private Pen blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            black = new Pen(Color.Black);
            blue = new Pen(Color.Blue);
            calculate();
        }

        private void drawGraph(Quadratic q)
        {
            graphBox.Image = new Bitmap(graphBox.Width, graphBox.Height);

            Graphics graph;
            graph = Graphics.FromImage(graphBox.Image);
            graph.Clear(Color.White);

            Point p1, p2;

            p1 = new Point((int)(graphBox.Width / 2), 0);
            p2 = new Point((int)(graphBox.Width / 2), graphBox.Height);
            graph.DrawLine(black, p1, p2);

            p2 = new Point(p2.X - 10, p2.Y - 17);
            graph.DrawString("y", Font, black.Brush, p2);

            p1 = new Point(0, (int)(graphBox.Height / 2));
            p2 = new Point(graphBox.Width, (int)(graphBox.Height / 2));
            graph.DrawLine(black, p1, p2);

            p2 = new Point(p2.X - 13, p2.Y + 2);
            graph.DrawString("x", Font, black.Brush, p2);

            List<Point> points = new List<Point>();

            int a, num = 20, scale = (int)Math.Abs(q.a / 5);

            scale = scale == 0 ? 1 : scale;

            scale *= 2;
            for (int i = 0; i <= num; ++i)
            {
                a = i - num / 2;
                points.Add(new Point(graphBox.Width / 2 + a * scale, graphBox.Height / 2 - (int)((q.a * (a - q.h) * (a - q.h) + q.k) / scale)));
            }

            graph.DrawCurve(blue, points.ToArray());

            string s;

            for (int i = 1; i <= 3; ++i)
            {
                s = (i * scale).ToString();
                p1 = new Point(graphBox.Width / 2 + 10 * i, graphBox.Height / 2);
                p2 = new Point(p1.X, p1.Y + 5);
                graph.DrawLine(black, p1, p2);

                p2 = new Point(p2.X - (TextRenderer.MeasureText(s, Font).Width / 2), p2.Y + 3);
                graph.DrawString(s, Font, black.Brush, p2);
            }

            for (int i = 1; i <= 3; ++i)
            {
                s = (i * scale).ToString();
                p1 = new Point(graphBox.Width / 2, graphBox.Height / 2 - 10 * i);
                p2 = new Point(p1.X - 5, p1.Y);
                graph.DrawLine(black, p1, p2);

                p2 = new Point(p2.X - 5 - (TextRenderer.MeasureText(s, Font).Width / 2), p2.Y - 7);
                graph.DrawString(s, Font, black.Brush, p2);
            }
        }

        private decimal trimText(string text, bool coefficient = true)
        {
            string str = "";

            bool neg = false, dec = false;

            foreach (char c in text)
            {
                if ((c >= '0' && c <= '9') || (c == '-' && !neg || (c == '.' && !dec)))
                {
                    neg = c == '-' ? true : neg;
                    dec = c == '.' ? true : dec;
                    str += c;
                }
            }

            if (str == "" && coefficient)
                str = "1";
            else if (str == "" && !coefficient)
                str = "0";

            return Convert.ToDecimal(str);
        }

        private void calculate()
        {
            decimal a = trimText(aBox.Text), b = trimText(bBox.Text), c = trimText(cBox.Text, false);
            if (a == 0)
                return;
            if (quadraticRadio.Checked)
            {
                b = trimText(bBox.Text, false);
                Quadratic q = Quadratics.calculateQuadratic(a, b, c);;
                answerLabel.Text = q.text;
                drawGraph(q);
            }
            else
                answerLabel.Text = Trinomials.calculateTrinomial((int)Math.Round(a), (int)Math.Round(b), (int)Math.Round(c));
        }

        private void quadraticRadio_CheckedChanged(object sender, EventArgs e)
        {
            quadraticLabel.Visible = true;
            graphBox.Visible = true;
            calculate();
        }

        private void trinomialRadio_CheckedChanged(object sender, EventArgs e)
        {
            quadraticLabel.Visible = false;
            graphBox.Visible = false;
            calculate();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void abcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Enter key
            {
                calculate();
            }
        }
    }
}
