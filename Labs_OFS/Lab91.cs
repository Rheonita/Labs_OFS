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
    public partial class Lab91 : Form
    {
        public Lab91()
        {
            InitializeComponent();
        }
        double x,y, x0, xk, a, b, dx;

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            for(i = 0; i < dataGridView1.RowCount-1; i++)
            {
                dataGridView1.Rows.RemoveAt(i--);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5,3";
            textBox2.Text = "10,3";
            textBox3.Text = "0,25";
            textBox5.Text = "1,35";
            textBox4.Text = "-6,25";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (j = 0; j < dataGridView1.RowCount - 1; j++)
            {
                dataGridView1.Rows.RemoveAt(j--);
            }
            x0 = double.Parse(textBox1.Text);
            xk = double.Parse(textBox2.Text);
            dx = double.Parse(textBox3.Text);
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox4.Text);
            
            if (x0 < xk)
            {                
                int count = (int)Math.Ceiling((xk - x0) / dx) + 1;
                double[] x1 = new double[count];
                double[] y1 = new double[count];
                x = x0;
                int i = 0;
                while (x <= xk)
                {
                    dataGridView1.Rows.Add();
                    y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                    dataGridView1[0, i].Value = x;
                    dataGridView1[1, i].Value = y;

                    x1[i] = x;
                    y1[i] = y;
                    x = x + dx;
                    i++;
                }
                chart1.ChartAreas[0].AxisX.Minimum = x0;
                chart1.ChartAreas[0].AxisX.Maximum = xk;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;
                chart1.Series[0].Points.DataBindY(y1);
            }
            else if (x0 > xk)
            {
                int count = (int)Math.Ceiling((x0 - xk) / dx) + 1;
                double[] x1 = new double[count];
                double[] y1 = new double[count];
                x = x0;
                int i = 0;
                while (xk <= x)
                {
                    dataGridView1.Rows.Add();
                    y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                    dataGridView1[0, i].Value = x;
                    dataGridView1[1, i].Value = y;
                    x1[i] = x;
                    y1[i] = y;
                    x = x - dx;
                    i++;
                }
                chart1.ChartAreas[0].AxisX.Minimum = xk;
                chart1.ChartAreas[0].AxisX.Maximum = x0;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;
                chart1.Series[0].Points.DataBindY(y1);
            }          
            
            
            //chart1.Series[1].Points.DataBindXY(x1, y1);
        }
    }
}
