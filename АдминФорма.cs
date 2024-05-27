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
    public partial class АдминФорма : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.baska);
        DataTable Диспетчеры = new DataTable();
        public АдминФорма()
        {
            InitializeComponent();
        }
        private void АдминФорма_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДДиспетчеры1.Диспетчеры". При необходимости она может быть перемещена или удалена.
            this.диспетчерыTableAdapter.Fill(this.бДДиспетчеры1.Диспетчеры);
        }
        private void АдминФорма_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.УспешнаяАвторизация = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Пользователь = "Вы не авторизованы";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void ИзображениеВыход_Click(object sender, EventArgs e)
        {
            DialogResult РезультатВыхода = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из аккаунта", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (РезультатВыхода == DialogResult.OK)
            {
                this.Hide();
                Properties.Settings.Default.УспешнаяАвторизация = false;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Пользователь = "Вы не авторизованы";
                Properties.Settings.Default.Save();
                Загрузка frmЗагрузка = new Загрузка();
                frmЗагрузка.Show();
            }
        }
        private void Добавление()
        {
            con.Open();

            string ЛогинДиспетчер = Логин.Text;
            string ПарольДиспетчер = Пароль.Text;

            string quere = $"select count(*) from Диспетчеры where Логин='{ЛогинДиспетчер}'";
            SqlCommand command = new SqlCommand(quere, con);
            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Аккаунт с данным логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand insert = new SqlCommand($"insert into Диспетчеры(Логин,Пароль) values ('{ЛогинДиспетчер}','{ПарольДиспетчер}')", con);
                if (insert.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Успешное добавление данных!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновление таблицы
                    string query = "SELECT * FROM Диспетчеры";
                    SqlDataAdapter updateTable = new SqlDataAdapter(query, con);

                    Диспетчеры.Clear();
                    updateTable.Fill(Диспетчеры);
                    БДДиспетчеры.DataSource = Диспетчеры;
                }
            }           
            con.Close();
        }     
        private void Добавить_Click(object sender, EventArgs e)
        {
            string ЛогинДиспетчер = Логин.Text;
            string ПарольДиспетчер = Пароль.Text;

            // Проверка на пустые значения
            if (string.IsNullOrWhiteSpace(ЛогинДиспетчер) || string.IsNullOrWhiteSpace(ПарольДиспетчер))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Добавление();
            }
        }
        private void Удаление()
        {
            con.Open();

            string ЛогинДиспетчер = Логин.Text;

            string quere = $"select count(*) from Диспетчеры where Логин='{ЛогинДиспетчер}'";
            SqlCommand command = new SqlCommand(quere, con);
            int count = (int)command.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand delete = new SqlCommand($"delete from Диспетчеры where Логин='{ЛогинДиспетчер}'", con);
                if (delete.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Диспетчер успешно удален.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновление таблицы
                    string query = "SELECT * FROM Диспетчеры";
                    SqlDataAdapter updateTable = new SqlDataAdapter(query, con);

                    Диспетчеры.Clear();
                    updateTable.Fill(Диспетчеры);
                    БДДиспетчеры.DataSource = Диспетчеры;

                    // Выделение последней удаленной строки
                    if (БДДиспетчеры.Rows.Count > 0)
                    {
                        int lastIndex = БДДиспетчеры.Rows.Count - 1;
                        БДДиспетчеры.ClearSelection();
                        БДДиспетчеры.Rows[lastIndex].Selected = true;
                    }
                }
            }
            con.Close();
        }
        private void БДДиспетчеры_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = БДДиспетчеры.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Проверяем, была ли нажата вся строка
                if (selectedCell.RowIndex == e.RowIndex)
                {
                    Удаление();
                }
                else
                {
                    Удаление();
                }
            }
        }
        private void Удаление_Click(object sender, EventArgs e)
        {
            DialogResult РезультатВыхода = MessageBox.Show("Вы уверены, что хотите удалить выбранного диспетчера? Это действие нельзя отменить!", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (РезультатВыхода == DialogResult.OK)
            {
                Удаление();
            }
        }

    }
}
