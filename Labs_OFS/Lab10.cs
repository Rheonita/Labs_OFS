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
    public partial class Lab10 : Form
    {
        public Lab10()
        {
            InitializeComponent();
        }

        

        private void номер1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _50Lines _50 = new _50Lines();
            _50.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MixedPaint mixed = new MixedPaint();
            mixed.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Polygon polygon = new Polygon();
            polygon.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Shtryh shtryh = new Shtryh();
            shtryh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Smes smes = new Smes();
            smes.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

