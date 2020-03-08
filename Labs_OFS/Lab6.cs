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
    public partial class Lab6 : Form
    {
        public Lab6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            // Считываем строку в переменную str
            string str = (string)listBox1.Items[index];
            // Узнаем количество символов в строке
            int len = str.Length;
            string strdigs = "";
            // Устанавливаем счетчик символов в 0
            int i = 0;
            // Организуем цикл перебора всех символов в строке
            while (i < len)
            {
                // Если нашли пробел, то увеличиваем 
                // счетчик пробелов на 1
                if (Char.IsDigit(str[i]))
                {
                    strdigs += str[i];
                }
                i++;
            }
            textBox1.Text = strdigs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
