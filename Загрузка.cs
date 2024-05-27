using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РасписаниеАэропорт.Поляков
{
    public partial class Загрузка : Form
    {
        private Random random = new Random();
        private int Zero = 0;
        public Загрузка()
        {
            InitializeComponent();
            ЗагрузкаПриложения.Interval = 100;
            ЗагрузкаПриложения.Tick += timer1_Tick;
            ЗагрузкаПриложения.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomIncrement = random.Next(1, 10); // Генерация случайного прибавления от 1 до 4
            if (randomIncrement == 0 && Zero < 4)
            {
                Zero++;
            }
            else
            {
                progressBar1.Value = Math.Min(progressBar1.Value + randomIncrement, 100); // Прибавление случайного числа, но не больше 4
            }

            label1.Text = progressBar1.Value.ToString() + "%";
            panel1.Invalidate();
            if (label1.Text == "100%")
            {
                if (Properties.Settings.Default.Пользователь == "admin")
                {
                    АдминФорма frmАдмин = new АдминФорма();
                    frmАдмин.Show();
                    this.Hide();
                    ((Timer)sender).Stop();
                }
                else
                {
                    Главная frm2 = new Главная();
                    frm2.Show();
                    this.Hide();
                    ((Timer)sender).Stop();
                }                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int padding = 10;
            int diameter = Math.Min(panel1.Width, panel1.Height) - padding * 2;
            int x = (panel1.Width - diameter) / 2; // расчет координаты X прогресс-бара
            int y = (panel1.Height - diameter) / 2; // расчет координаты Y прогресс-бара
            Rectangle rect = new Rectangle(x, y, diameter, diameter);
            float sweepAngle = 3.6f * progressBar1.Value; // пересчёт величины дуги
            g.DrawArc(Pens.Cyan, rect, -90, sweepAngle);
        }

    }
}
