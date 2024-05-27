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
    public partial class Информация : Form
    {
        public Информация()
        {
            InitializeComponent();
        }

        private void ИзображениеВыход_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

