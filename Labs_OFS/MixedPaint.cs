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
    public partial class MixedPaint : Form
    {
        public MixedPaint()
        {
            InitializeComponent();
        }

        private void MixedPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.Brown);
            
            Pen pen = new Pen(Color.Black);
            g.FillEllipse(b, 100, 100, 170, 100);
            g.DrawEllipse(pen, 0, 65, 105, 55);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
