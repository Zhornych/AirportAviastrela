using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РасписаниеАэропорт.Поляков
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool createdNew;
            using (System.Threading.Mutex mutex = new System.Threading.Mutex(true, "SingleInstanceFormMutex", out createdNew))
            {
                if (createdNew)
                {
                    Application.Run(new Загрузка());
                }
                else
                {
                    MessageBox.Show("Приложение уже запущено!", "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

