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
    public partial class Lab7 : Form
    {
        double[] Mas = new double[25];
        public Lab7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            // Инициализируем класс случайных чисел
            Random rand = new Random();
            // Генерируем и выводим 15 элементов
            for (int i = 0; i < 25; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() +
     "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            // Обрабатываем все элементы
            for (int i = 0; i < 25; i++)
            {
                if (Mas[i] < 0)
                {
                    Mas[i] = Math.Pow(Mas[i], 2);
                }
                else if (Mas[i] > 0)
                {
                    Mas[i] += 7;
                }
                else if (Mas[i] == 0)
                {
                    Mas[i] = 0;
                }
                listBox2.Items.Add("Mas[" + Convert.ToString(i)
                 + "] = " + Mas[i].ToString());
            }
    }
    }
}
