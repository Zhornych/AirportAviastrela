using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace РасписаниеАэропорт.Поляков
{
    public partial class Аккаунт : Form
    {
        bool ПроверкаСкрытияПароля = true;
        string ЛогинДиспетчер = "";
        string ПарольДиспетчер = "";
        SqlConnection con = new SqlConnection(Properties.Settings.Default.baska);
        public Аккаунт()
        {           
            InitializeComponent();
        }

        private void Закрыть_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void КнопкаАвторизации_Click(object sender, EventArgs e)
        {          
            if (string.IsNullOrWhiteSpace(Логин.Text) || string.IsNullOrWhiteSpace(Пароль.Text))
            {
                MessageBox.Show("Пустые значения логина или пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Логин.Text == "admin" & Пароль.Text == "admin")
            {
                Properties.Settings.Default.Пользователь = "";
                Properties.Settings.Default.Пользователь = "admin";
                Properties.Settings.Default.Save();
                Properties.Settings.Default.УспешнаяАвторизация = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("Добро пожаловать, Администратор.", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                АдминФорма frmАдмин = new АдминФорма();
                frmАдмин.Show();
            }
            else
            {
                login();
            }           
        }
        private void login()
        {          
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable Table = new DataTable();
            ЛогинДиспетчер = Логин.Text;
            ПарольДиспетчер = Пароль.Text;

            string query = $"select Логин, Пароль from Диспетчеры where Логин='{ЛогинДиспетчер}' and Пароль='{ПарольДиспетчер}'";
            SqlCommand command = new SqlCommand(query, con);
            adapter.SelectCommand = command;
            adapter.Fill(Table);

            if (Table.Rows.Count == 1)
            {
                Properties.Settings.Default.Пользователь = "";
                Properties.Settings.Default.Пользователь = ЛогинДиспетчер;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.УспешнаяАвторизация = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("Добро пожаловать, Диспетчер.", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль/данные введены с ошибками", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void СкрытьПароль_Click(object sender, EventArgs e)
        {
            ПроверкаСкрытияПароля = !ПроверкаСкрытияПароля;
            if (ПроверкаСкрытияПароля == true)
            {
                СкрытьПароль.Image = Properties.Resources.ПарольСкрыт;
                Пароль.PasswordChar = '*';  
            }
            else
            {
                СкрытьПароль.Image = Properties.Resources.ПарольВиден;
                Пароль.PasswordChar = Логин.PasswordChar;
            }
        }
        private void Пароль_Enter(object sender, EventArgs e)
        {
            Пароль.PasswordChar = Логин.PasswordChar;
        }
        private void Пароль_Leave(object sender, EventArgs e)
        {
            Пароль.PasswordChar = '*';            
        }
    }
}
    
