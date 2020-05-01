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
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }
        double x, y, z, w, w1, w2;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //w1 - получает значение модуля cosx-cosy в степени 1+2*sin(y)
        // w2 - получает значение сложения z в итерации

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4000";
            textBox5.Text = "-0,875";
            textBox3.Text = "-0,00048";
            textBox4.Text = "1,9873";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox5.Text);
            z = double.Parse(textBox3.Text);
            //x = x * Math.Pow(10, 4);
            //z = z * Math.Pow(10, -3);
            w1 = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2*Math.Pow(Math.Sin(y),2)); // вычисление модуля 
            w2 = (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4); // вычисление итерации
            w = w1 * w2; // умножение первой части на вторую согласно условию задачи
            w = Math.Round(w, 4); // округление результата до 4 разрядов после запятой
            textBox2.Text += Environment.NewLine + "W1 = " +w1.ToString() + Environment.NewLine + "W2 = " + w2.ToString() + Environment.NewLine + "W= " + w.ToString() + Environment.NewLine + "X * 10 в степени 4 = " + x.ToString() + Environment.NewLine + "Z * 10 в степени -3 = " + z.ToString();

        }

          }
}
