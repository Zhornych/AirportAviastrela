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
    public partial class Таблицы : Form
    {
        public Таблицы()
        {
            InitializeComponent();
        }

        private void ИзображениеВыход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ИконкаАэропорта_Click(object sender, EventArgs e)
        {
            Главная frmГлавная = new Главная();
            frmГлавная.Show();
            this.Hide();
        }




        //Кнопка Главной
        private void ПанельГлавная_Click(object sender, EventArgs e)
        {
            Главная frmГлавная = new Главная();
            frmГлавная.Show();
            this.Hide();
        }
        private void ПанельГлавная_MouseEnter(object sender, EventArgs e)
        {
            ГлавнаяТекст.ForeColor = Color.White;
            ПанельГлавная.BackColor = Color.CornflowerBlue;
            ГлавнаяТекст.BackColor = Color.CornflowerBlue;
            ИзображениеГлавная.BackColor = Color.CornflowerBlue;
        }
        private void ПанельГлавная_MouseLeave(object sender, EventArgs e)
        {
            ГлавнаяТекст.ForeColor = Color.Black;
            ПанельГлавная.BackColor = Color.SteelBlue;
            ГлавнаяТекст.BackColor = Color.SteelBlue;
            ИзображениеГлавная.BackColor = Color.SteelBlue;
        }


        //кнопка Расписания
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

        private void Пассажиры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "самолётыБД.Самолёт". При необходимости она может быть перемещена или удалена.
            this.самолётTableAdapter.Fill(this.самолётыБД.Самолёт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пилотыБД.Пилоты". При необходимости она может быть перемещена или удалена.
            this.пилотыTableAdapter.Fill(this.пилотыБД.Пилоты);
            ////САМОЛЁТЫ
            //Модель.Items.Add("Одуван О239");
            //Модель.Items.Add("Стрела 530");
            //Модель.Items.Add("Огниво А23Б");
            //Модель.Items.Add("Ласточка 93");
            //Модель.Items.Add("Толстяк ТБ32");

            //Статус.Items.Add("Назначен");
            //Статус.Items.Add("Не назначен");
            //Статус.Items.Add("В ремонте");

            //Пилот.Items.Add(" ");
            //Пилот.Items.Add(" ");
            //Пилот.Items.Add(" ");
            //Пилот.Items.Add(" ");
            //// + здесь будет добавление idПилотов из БД

            ////Добавление в список для таблицы Пилоты
            //Стаж.Items.Add("Менее 1 года");
            //Стаж.Items.Add("От 1 до 5 лет");
            //Стаж.Items.Add("От 5 до 10 лет");
            //Стаж.Items.Add("Более 10 лет");

            //Лицензия.Items.Add("Активная");
            //Лицензия.Items.Add("Истёкшая");
            //Лицензия.Items.Add("Неактивная");
        }
    }
}
