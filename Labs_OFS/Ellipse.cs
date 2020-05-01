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
    public partial class Ellipse : Form
    {
        public Ellipse()
        {
            InitializeComponent();
        }

        private void Ellipse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush B = new SolidBrush(Color.DeepPink);
            g.FillRectangle(B, 100, 100, 100, 150);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


