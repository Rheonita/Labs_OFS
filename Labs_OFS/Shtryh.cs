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
    public partial class Shtryh : Form
    {
        public Shtryh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Shtryh_Paint(object sender, PaintEventArgs e)
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
            g.FillPolygon(b, points);
        }
    }
}
