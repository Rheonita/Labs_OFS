using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_OFS
{
    public partial class Smes : Form
    {
        public Smes()
        {
            InitializeComponent();
        }

        private void Smes_Paint(object sender, PaintEventArgs e)
        {
            Point[] points = new Point[50];
            for (int i = 0; i < 20; i++)
            {
                int xPos;
                if (i % 2 == 0)
                {
                    xPos = 10;
                }
                else
                {
                    xPos = 400;
                }
                points[i] = new Point(xPos, 10 * i);
            }
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.BlueViolet);
            SolidBrush b1 = new SolidBrush(Color.Black);
            SolidBrush B = new SolidBrush(Color.PaleGreen);
            g.FillPolygon(b, points);
            g.FillEllipse(b1, 50, 150, 170, 100);
            Point[] polygonPoints = new Point[6];
            polygonPoints[0] = new Point(50, 150);
            polygonPoints[1] = new Point(20, 65);
            polygonPoints[2] = new Point(100, 10);
            polygonPoints[3] = new Point(175, 65);
            polygonPoints[4] = new Point(150, 150);
            polygonPoints[5] = new Point(50, 150);
            e.Graphics.DrawPolygon(Pens.Black, polygonPoints);
            g.FillRectangle(B, 74, 176, 100, 150);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
