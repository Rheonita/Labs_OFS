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
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }
        double x,y, x0, xk, a, b, dx;

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5,3";
            textBox2.Text = "10,3";
            textBox3.Text = "0,25";
            textBox4.Text = "1,35";
            textBox6.Text = "-6,25";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x0 = double.Parse(textBox1.Text);
            xk = double.Parse(textBox2.Text);
            dx = double.Parse(textBox3.Text);
            a = double.Parse(textBox4.Text);
            b = double.Parse(textBox6.Text);
            x = x0;
            while (x <= xk)
            {
                y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                textBox5.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
