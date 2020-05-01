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
    public partial class _50Lines : Form
    {
        public _50Lines()
        {
            InitializeComponent();
        }

        private void _50Lines_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < 50; i++)
                g.DrawLine(new Pen(Brushes.Black, 2),
                10, 4 * i + 20, 200, 4 * i + 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
