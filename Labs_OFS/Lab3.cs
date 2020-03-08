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
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }
        double fx,x,y,d;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ParseCheckX(textBox1.Text) == false || ParseCheckY(textBox2.Text)==false) // проверка корректности заполненных полей
            {

            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    fx = Math.Pow(x, 2);
                    if (x > y)
                    {
                        d = XmoreThanY(fx, y);                       
                    }
                    else if (x < y)
                    {
                        d = YmoreThanX(fx, y);
                    }
                    else
                    {
                        d = XEqualY(fx, y);
                    }
                    textBox3.Text = d.ToString();
                }
                else if (radioButton2.Checked == true)
                {
                    fx = Math.Sinh(x);
                    if (x > y)
                    {
                        d = XmoreThanY(fx, y);
                    }
                    else if (x < y)
                    {
                        d = YmoreThanX(fx, y);
                    }
                    else
                    {
                        d = XEqualY(fx, y);
                    }
                    textBox3.Text = d.ToString();
                }
                else if (radioButton3.Checked == true)
                {
                    fx = Math.Exp(x);
                    if (x > y)
                    {
                        d = XmoreThanY(fx, y);
                    }
                    else if (x < y)
                    {
                        d = YmoreThanX(fx, y);
                    }
                    else
                    {
                        d = XEqualY(fx, y);
                    }
                    textBox3.Text = d.ToString();
                }
            }
        }
        public bool ParseCheckY(string val)
        {
            try
            {
                y = double.Parse(val);
                return true;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение Y!");
                return false;
            }
        }//Функция проверяющая поле X
        public bool ParseCheckX(string val)
        {
            try
            {
                x = double.Parse(val);
                return true;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение X!");
                return false;
            }
        }// Функция проверяющая поле Y

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double XmoreThanY(double a, double b) // x>y
        {
            return Math.Pow(a - b, 3) + Math.Atan(a);
        }
        public double YmoreThanX(double a, double b) // Y>x
        {
            return Math.Pow(b - a, 3)+ Math.Atan(a);
        }
        public double XEqualY(double a, double b) // x == y
        {
            return Math.Pow(b + a, 3) + 0.5;
        }
    }
}
