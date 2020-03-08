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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void лабораторнаяРабота1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void лабораторнаяРабота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab1 lbwindow = new Lab1();
            lbwindow.Show();

        }

        private void лабораторнаяРабота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab2 lbwindow = new Lab2();
            lbwindow.Show();
        }

        private void лабораторнаяРабота3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab3 lbwindow = new Lab3();
            lbwindow.Show();
        }

        private void лабораторнаяРабота4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab4 lbwindow = new Lab4();
            lbwindow.Show();
        }
    }
}
