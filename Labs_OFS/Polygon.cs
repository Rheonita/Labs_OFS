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
    public partial class Polygon : Form
    {
        public Polygon()
        {
            InitializeComponent();
        }

        private void Polygon_Paint(object sender, PaintEventArgs e)
        {
            Point[] polygonPoints = new Point[6];
            polygonPoints[0] = new Point(50, 150);
            polygonPoints[1] = new Point(20, 65);
            polygonPoints[2] = new Point(100, 10);
            polygonPoints[3] = new Point(175, 65);
            polygonPoints[4] = new Point(150, 150);
            polygonPoints[5] = new Point(50, 150);
            e.Graphics.DrawPolygon(Pens.Black, polygonPoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
