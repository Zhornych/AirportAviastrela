using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace РасписаниеАэропорт.Поляков
{
    public partial class Расписание : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.baska);
        public Расписание()
        {
            InitializeComponent();
            //Для Даты
            DateTime.Now.ToString();
            Время.Interval = 1000;
            Время.Start();
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

        private void Добавление()
        {
            string номерРейса = НомерРейсаРасп.Text;
            string фактВремяВылета = ФактВремяВылета.Text;
            string фактВремяПрибытия = ФактВремяПрибытия.Text;

            string датаВылета = ДатаВылета.Text;
            string времяРейса = ВремяРейса.Text;
            string авиакомпания = Авиакомпания.SelectedItem.ToString();
            string статус = Статус.SelectedItem.ToString();

            string queryFlight = "INSERT INTO Рейсы (НомерРейса, ФактВремяВылета, ФактВремяПрибытия) VALUES (@НомерРейса, @ФактВремяВылета, @ФактВремяПрибытия)";
            SqlCommand commandFlight = new SqlCommand(queryFlight, con);
            commandFlight.Parameters.AddWithValue("@НомерРейса", номерРейса);
            commandFlight.Parameters.AddWithValue("@ФактВремяВылета", фактВремяВылета);
            commandFlight.Parameters.AddWithValue("@ФактВремяПрибытия", фактВремяПрибытия);
            commandFlight.ExecuteNonQuery();
            // Обновление таблицы
            string query = "SELECT * FROM Рейсы";
            SqlDataAdapter updateTable = new SqlDataAdapter(query, con);

            string querySchedule = "INSERT INTO Расписание (ДатаВылета, ВремяРейса, Авиакомпания, Статус) VALUES (@ДатаВылета, @ВремяРейса, @Авиакомпания, @Статус)";
            SqlCommand commandSchedule = new SqlCommand(querySchedule, con);
            commandSchedule.Parameters.AddWithValue("@ДатаВылета", датаВылета);
            commandSchedule.Parameters.AddWithValue("@ВремяРейса", времяРейса);
            commandSchedule.Parameters.AddWithValue("@Авиакомпания", авиакомпания);
            commandSchedule.Parameters.AddWithValue("@Статус", статус);
            commandSchedule.ExecuteNonQuery();
            // Обновление таблицы
            string query1 = "SELECT * FROM Расписание";
            SqlDataAdapter updateTable1 = new SqlDataAdapter(query1, con);

            MessageBox.Show("Данные успешно добавлены в базу данных.");
        }

        private void ДобавитьДанные_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(НомерРейсаРасп.Text))
            {
                if (!string.IsNullOrWhiteSpace(ФактВремяВылета.Text) || !ФактВремяВылета.Text.Contains("-") || !ФактВремяВылета.Text.Contains(".") || !ФактВремяВылета.Text.Contains(":"))
                {
                    if (!string.IsNullOrWhiteSpace(ФактВремяПрибытия.Text) || !ФактВремяПрибытия.Text.Contains("-") || !ФактВремяПрибытия.Text.Contains(".") || !ФактВремяПрибытия.Text.Contains(":"))
                    {
                        if (!string.IsNullOrWhiteSpace(ДатаВылета.Text) || !ДатаВылета.Text.Contains("-") || !ДатаВылета.Text.Contains(".") || !ДатаВылета.Text.Contains(":"))
                        {
                            if (!string.IsNullOrWhiteSpace(ВремяРейса.Text) || !ВремяРейса.Text.Contains("-") || !ВремяРейса.Text.Contains(".") || !ВремяРейса.Text.Contains(":"))
                            {
                                if (Авиакомпания.SelectedItem != null && !string.IsNullOrWhiteSpace(Авиакомпания.SelectedItem.ToString()))
                                {
                                    if (Прибытие.SelectedItem != null && !string.IsNullOrWhiteSpace(Прибытие.SelectedItem.ToString()))
                                    {
                                        if (Статус.SelectedItem != null && !string.IsNullOrWhiteSpace(Статус.SelectedItem.ToString()))
                                        {
                                            Добавление();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Выберите статус!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Выберите город прибытия!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Выберите авиакомпанию!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Поле Время рейса пустое!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Поле Дата Вылета пустое!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле Фактическое Время Прибытия пустое!");
                    }
                }
                else
                {
                    MessageBox.Show("Поле Фактическое Время Вылета пустое!");
                }
            }
            else
            {
                MessageBox.Show("Поле Номер рейса содержит недопустимые символы!");
            }
        }

        private void Расписание_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "расписаниеБД.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.расписаниеБД.Расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рейсыБД.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.рейсыБД.Рейсы);
            if (Properties.Settings.Default.УспешнаяАвторизация == true)
            {
                КнопкаДляПокупки.Visible = false;
                ПанельТаблицы.Visible = true;
                ДобавлениеРасписания.Visible = true;
            }
            if (Properties.Settings.Default.УспешнаяАвторизация != true)
            {
                КнопкаДляПокупки.Visible = true;
                ПанельТаблицы.Visible = false;
                ДобавлениеРасписания.Visible = false;
            }

            string query = "SELECT Город FROM Аэропорт";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Прибытие.Items.Add(reader["Город"].ToString());
            }
            reader.Close();

            //Добавление в список для таблицы Расписание
            Авиакомпания.Items.Add("Аврора Скай");
            Авиакомпания.Items.Add("Призрачный Летун");
            Авиакомпания.Items.Add("Летархия");
            Авиакомпания.Items.Add("Таинственные слоники");
            Авиакомпания.Items.Add("Скупые Фениксы");
            Авиакомпания.Items.Add("Голубые еноты");

            Статус.Items.Add("Активен");
            Статус.Items.Add("Отменён");
            Статус.Items.Add("Завершён");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo moscovTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            DateTime moscovTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, moscovTimeZone);
            Дата_Время.Font = new Font("MultiType Brick Blocks", 12);
            Дата_Время.Text = DateTime.Now.ToString($"Дата:  dd/MM/yyyy\nВремя:  HH:mm:ss\nВремя по МСК: {moscovTime.ToString("HH:mm:ss")}");
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


        private void КнопкаДляПокупки_Click(object sender, EventArgs e)
        {
            Код.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Код.Visible = false;
        }
    }
}
