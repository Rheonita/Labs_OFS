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
            Lab6 lbwindow = new Lab6();
            lbwindow.Show();
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

        private void лабораторнаяРабота5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab5 lbwindow = new Lab5();
            lbwindow.Show();
        }

        private void лабораторнаяРабота7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab7 lbwindow = new Lab7();
            lbwindow.Show();
        }

        private void лабораторнаяРабота8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab8 lbwindow = new Lab8();
            lbwindow.Show();
        }
    }
}
