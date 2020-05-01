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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x, y;
            x = rand.Next(panel2.Width);
            y = rand.Next(panel2.Height);
            //int i = 1;
            //while (i <= 3)
            //{
            //    Button FirstMission = new Button
            //    {
            //        Text = "Кнопочка",
            //        Location = new Point(i * 5, i * 5)

            //    };
            //    panel2.Controls.Add(FirstMission);
            //    i += 1;
            //}
           //int i = 1;
            
            Button FirstMission = new Button();
            FirstMission.Text = "Кнопочка";
            FirstMission.Location = new Point(x,y);
            panel2.Controls.Add(FirstMission);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x, y;
            x = rand.Next(panel3.Width);
            y = rand.Next(panel3.Height);
            //int i = 1;
            //while (i <= 3)
            //{
            //    TextBox SecondMission = new TextBox
            //    {
            //        Text = "Поле",
            //        Location = new Point(i * 5, i * 5)
            //    };
            //    panel3.Controls.Add(SecondMission);
            //    i += 1;
            //}

            
            TextBox FirstMission = new TextBox();
            FirstMission.Text = "Текст";
            FirstMission.Location = new Point(x, y);
            panel3.Controls.Add(FirstMission);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x, y;
            x = rand.Next(panel2.Width);
            y = rand.Next(panel2.Height);
            //int i = 1;
            //while (i <= 3)
            //{
            //    Label ThirdMission = new Label
            //    {
            //        Text = "Лейбл",
            //        Location = new Point(i * 25, i * 25)
            //    };
            //    panel1.Controls.Add(ThirdMission);
            //    i += 1;
            //}
                        Label FirstMission = new Label();
            FirstMission.Text = "Лейбл";
            FirstMission.Location = new Point(x,y);
            panel1.Controls.Add(FirstMission);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
