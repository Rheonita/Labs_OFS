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
    public partial class Lab8 : Form
    {
        public Lab8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            dataGridView1.RowCount = 15; // Кол‐во строк
            dataGridView1.ColumnCount = 15; // Кол‐во столбцов
            int[,] a = new int[15, 15]; // Инициализируем массив
            int i, j;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i, j] = rand.Next(-3, 10);
            // Выводим матрицу в dataGridView1
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value =
                     a[i, j].ToString();
            // Поиск максимального элемента 
            // на дополнительной диагонали
            bool doubleflag = false;
            bool flag = false;
            int sumofavg = 0;
            int numofstr = 0;
            int k=0;
            int avg = 0;
            for (i = 0; i < 15; i++)
            {
                numofstr++;
                for (j = 0; j < 15; j++)
                {                    
                    if (a[i, 0] == 1)
                    {
                        k = numofstr;
                        avg += a[i, j];
                        //sumofavg = avg / 15;
                        flag = true;
                    }
                    sumofavg = avg / 15;
                    
                }                
                //sumofavg = 0;
                //avg = 0;
            }
            if (flag == true)
            {
                textBox2.Text += "Среднее АФ = " + Convert.ToString(sumofavg) + Environment.NewLine + "Строка №" + Convert.ToString(k);
                doubleflag = true;
            }
            if (doubleflag == false)
            {
                textBox2.Text = "Такого числа нет";
            }                      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
