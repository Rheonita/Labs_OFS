using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_OFS
{
    public partial class Lab12 : Form
    {
        public Lab12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.Cancel) return;
                pictureBox1.Image = new Bitmap(ofd.FileName);             
                Bitmap[] rgb = GetRgbChannels(pictureBox1.Image);
                if(radioButton1.Checked == true)
                {
                    pictureBox3.Image = rgb[0];
                }
                else if(radioButton2.Checked == true)
                {
                    pictureBox3.Image = rgb[1];
                }
                else if(radioButton3.Checked == true)
                {
                    pictureBox3.Image = rgb[2];
                }
            }
        }

        static Bitmap[] GetRgbChannels(Image source)
        {
            Bitmap[] result = new Bitmap[3]; // объект для обработки изображения
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix[] matrices = new ColorMatrix[3];
            for (int i = 0; i < matrices.Length; i++)
            {
                float[][] elements ={
                new float[]{i == 0 ? 1 : 0, 0, 0, 0, 0},
                new float[]{0, i == 1 ? 1 : 0, 0, 0, 0},
                new float[]{0, 0, i == 2 ? 1 : 0, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 0}
    };
                matrices[i] = new ColorMatrix(elements);// цветовая матрица
            }
            int w = source.Width, h = source.Height;// ширина высота изображения
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Bitmap(source);//выбираем i картинку
                imageAttributes.ClearColorMatrix();//очищаем матрицу
                imageAttributes.SetColorMatrix(matrices[i], ColorMatrixFlag.Default, ColorAdjustType.Bitmap);//задаём настройки цвета матрицы
                using (Graphics g = Graphics.FromImage(result[i]))
                {
                    g.DrawImage(result[i], new Rectangle(0, 0, w, h), 0, 0, w, h, GraphicsUnit.Pixel, imageAttributes);//перерисовка изображения
                }
            }
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
