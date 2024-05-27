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
    public partial class Главная : Form
    {
        bool ПроверкаАвторизации = false;
        public Главная()
        {
            InitializeComponent();
            ЛогинПользователя.Text = Properties.Settings.Default.Пользователь;
            НеПоказыватьПанель.Checked = Properties.Settings.Default.ИнформационноеОкно;
        }
        private void Главная_Activated(object sender, EventArgs e)
        {
            ЛогинПользователя.Text = Properties.Settings.Default.Пользователь;
            if (Properties.Settings.Default.УспешнаяАвторизация == true)
            {
                ПанельТаблицы.Visible = true;
            }
            else
            {
                ПанельТаблицы.Visible = false;
            }

            if (Properties.Settings.Default.Пользователь == "admin")
            {
                this.Hide();
            }
        }
        private void Главная_Shown(object sender, EventArgs e)
        {
            ПанельИнформации.Visible = true;
        }

        private void НеПоказыватьПанель_CheckedChanged(object sender, EventArgs e)
        {
            //Обновляем состояние панели в зависимости от состояния чекбокса
            ПанельИнформации.Visible = !НеПоказыватьПанель.Checked; // инвертируем значение для скрытия панели
            Properties.Settings.Default.ИнформационноеОкно = НеПоказыватьПанель.Checked; // сохраняем состояние чекбокса
            Properties.Settings.Default.Save(); // сохраняем изменения в настройках приложения
        }
        private void ЗакрытьИнфоПанель_Click(object sender, EventArgs e)
        {
            ПанельИнформации.Visible = false;
        }

        private void ИзображениеВыход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ИзображениеИнформация_Click(object sender, EventArgs e)
        {
            Информация frmИнформация = new Информация();
            frmИнформация.ShowDialog();
        }



        //Кнопка Расписания
        private void ПанельРасписание_Click(object sender, EventArgs e)
        {
            Расписание frmРасписание = new Расписание();
            frmРасписание.Show();
            this.Hide();
        }
        private void ПанельРасписание_MouseEnter(object sender, EventArgs e)
        {
            РасписаниеТекст.ForeColor = Color.White;
            ПанельРасписание.BackColor = Color.CornflowerBlue;
            РасписаниеТекст.BackColor = Color.CornflowerBlue;
            ИзображениеРасписание.BackColor = Color.CornflowerBlue;
        }
        private void ПанельРасписание_MouseLeave(object sender, EventArgs e)
        {
            РасписаниеТекст.ForeColor = Color.Black;
            ПанельРасписание.BackColor = Color.SteelBlue;
            РасписаниеТекст.BackColor = Color.SteelBlue;
            ИзображениеРасписание.BackColor = Color.SteelBlue;
        }


        //Кнопка Таблицы
        private void ПанельТаблицы_Click(object sender, EventArgs e)
        {
            Таблицы frmРасписание = new Таблицы();
            frmРасписание.Show();
            this.Hide();
        }
        private void ПанельТаблицы_MouseEnter(object sender, EventArgs e)
        {
            ТаблицыТекст.ForeColor = Color.White;
            ПанельТаблицы.BackColor = Color.CornflowerBlue;
            ТаблицыТекст.BackColor = Color.CornflowerBlue;
            ИзображениеТаблицы.BackColor = Color.CornflowerBlue;
        }
        private void ПанельТаблицы_MouseLeave(object sender, EventArgs e)
        {
            ТаблицыТекст.ForeColor = Color.Black;
            ПанельТаблицы.BackColor = Color.SteelBlue;
            ТаблицыТекст.BackColor = Color.SteelBlue;
            ИзображениеТаблицы.BackColor = Color.SteelBlue;
        }


        //Кнопка Аккаунта
        private void ПанельАккаунт_Click(object sender, EventArgs e)
        {
            ПроверкаАвторизации = !ПроверкаАвторизации;
            if (ПроверкаАвторизации)
            {
                if (Properties.Settings.Default.УспешнаяАвторизация == false)
                {
                    Авторизован.Visible = false;
                    Аккаунт frmАккаунт = new Аккаунт();
                    frmАккаунт.ShowDialog();
                    ПроверкаАвторизации = false;
                }
                else
                {
                    Авторизован.Visible = true;
                }
            }
            else
            {
                if (Properties.Settings.Default.УспешнаяАвторизация == true)
                {
                    Авторизован.Visible = false;                
                }       
            }
        }
        private void Выход_Click(object sender, EventArgs e)
        {
            DialogResult РезультатВыхода = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из аккаунта", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (РезультатВыхода == DialogResult.OK)
            {
                ПанельТаблицы.Visible = false;
                Авторизован.Visible = false;
                ПроверкаАвторизации = false;
                Properties.Settings.Default.УспешнаяАвторизация = false;
                Properties.Settings.Default.Save();
            }
        }

        private void ПанельАккаунт_MouseEnter(object sender, EventArgs e)
        {
            АккаунтТекст.ForeColor = Color.White;
            ПанельАккаунт.BackColor = Color.CornflowerBlue;
            АккаунтТекст.BackColor = Color.CornflowerBlue;
            АккаунтИзображение.BackColor = Color.CornflowerBlue;
        }

        private void ПанельАккаунт_MouseLeave(object sender, EventArgs e)
        {
            АккаунтТекст.ForeColor = Color.Black;
            ПанельАккаунт.BackColor = Color.SteelBlue;
            АккаунтТекст.BackColor = Color.SteelBlue;
            АккаунтИзображение.BackColor = Color.SteelBlue;
        }

        private void Главная_Load(object sender, EventArgs e)
        {
            ЛогинПользователя.Text = Properties.Settings.Default.Пользователь;
            if (ЛогинПользователя.Text == "Вы не авторизованы")
            {
                {
                    Приветствие_Информация.Text = "Приветствую Вас в Системе Расписания полётов! \nЭто приложение предназначено для просмотра актуального расписания рейсов," +
                        "\nпоиска и покупки билетов, а также получения информации о вашем рейсе." +
                        "\n\nЗдесь вы сможете: " +
                        "\n1.Просматривать расписание рейсов и приобретать билеты." +
                        "\n2.Отслеживать информацию о ваших полетах." +
                        "\n3.Получать уведомления о изменениях времени вылета." +
                        "\n\nЖелаю Вам приятного пользования!";
                }
            }
            else
            {
                {
                    Приветствие_Информация.Text = "Приветствую Вас в Системе Диспетчера - Управления расписанием аэропорта! \nЭто приложение разработано  для управления расписанием авиарейсов," +
                    "\nмониторинга информации о пассажирах и самолётах." +
                    "\n\nЗдесь вы сможете: " +
                    "\n1.Добавлять, изменять и удалять информацию о рейсах." +
                    "\n2.Отслеживать информацию о пассажирах." +
                    "\n\nЖелаю Вам приятной работы!";
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsv.aero/");
        }
    }
}
