using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_OFS
{
    public partial class Lab11 : Form
    {
        const float PI = (float)Math.PI;
        GraphicsPath sin;// синусоида    
        int n; // продвижение синусоиды
        public Lab11()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            timer1.Tick += timer1_Tick;
            sin = new GraphicsPath();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++n >= sin.PointCount) n = 0;
            pictureBox1.Refresh();// обновляем для показания передвижения и анимации
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) // Зарисока picboxa
        {
            if (sin.PointCount == 0) return;
            PointF pt = sin.PathPoints[n];
            e.Graphics.ScaleTransform(1, -1);//масштаб
            e.Graphics.TranslateTransform(5, -pictureBox1.Height / 2);//сдвиг координат для перемещения
            e.Graphics.DrawPath(Pens.Blue, sin);  // рисуем путь синусоиды        
            e.Graphics.FillEllipse(Brushes.Yellow, RectangleF.FromLTRB(pt.X - 15, pt.Y - 15, pt.X + 15, pt.Y + 15));// рисуем кружок
        }

        private void CreateSinusoid(GraphicsPath sins, float maximum, Size size)
        {
            sins.Reset();
            PointF[] points = new PointF[1] { PointF.Empty };
            for (float i = 0; i <= maximum; i += 0.4f)
            {
                points[points.GetUpperBound(0)] = new PointF(i, (float)Math.Sin(i));
                Array.Resize<PointF>(ref points, points.Length + 1);
            }
            Array.Resize<PointF>(ref points, points.Length - 1);
            sins.AddCurve(points);
            Matrix m = new Matrix();
            m.Scale((float)(size.Width / maximum), 0.4f * size.Height);
            sins.Transform(m);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 0;
            CreateSinusoid(sin, 10f * PI, pictureBox1.ClientSize);
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
