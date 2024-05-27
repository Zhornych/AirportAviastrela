namespace РасписаниеАэропорт.Поляков
{
    partial class Загрузка
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ЗагрузкаПриложения = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ВерхняяПанель = new System.Windows.Forms.Panel();
            this.ЗагрузкаТекст = new System.Windows.Forms.Label();
            this.Закрыть = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.НижняяПанель = new System.Windows.Forms.Panel();
            this.ВерхняяПанель.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Закрыть)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.НижняяПанель.SuspendLayout();
            this.SuspendLayout();
            // 
            // ЗагрузкаПриложения
            // 
            this.ЗагрузкаПриложения.Enabled = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(465, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(24, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // ВерхняяПанель
            // 
            this.ВерхняяПанель.BackColor = System.Drawing.Color.SteelBlue;
            this.ВерхняяПанель.Controls.Add(this.ЗагрузкаТекст);
            this.ВерхняяПанель.Controls.Add(this.Закрыть);
            this.ВерхняяПанель.Location = new System.Drawing.Point(-5, -5);
            this.ВерхняяПанель.Name = "ВерхняяПанель";
            this.ВерхняяПанель.Size = new System.Drawing.Size(505, 62);
            this.ВерхняяПанель.TabIndex = 3;
            // 
            // ЗагрузкаТекст
            // 
            this.ЗагрузкаТекст.AutoSize = true;
            this.ЗагрузкаТекст.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ЗагрузкаТекст.ForeColor = System.Drawing.Color.DarkBlue;
            this.ЗагрузкаТекст.Location = new System.Drawing.Point(192, 20);
            this.ЗагрузкаТекст.Name = "ЗагрузкаТекст";
            this.ЗагрузкаТекст.Size = new System.Drawing.Size(125, 20);
            this.ЗагрузкаТекст.TabIndex = 0;
            this.ЗагрузкаТекст.Text = "\"Авиастрела\"";
            // 
            // Закрыть
            // 
            this.Закрыть.BackColor = System.Drawing.Color.SteelBlue;
            this.Закрыть.Image = global::РасписаниеАэропорт.Поляков.Properties.Resources.ЗакрытьПобочное;
            this.Закрыть.Location = new System.Drawing.Point(439, 9);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(37, 31);
            this.Закрыть.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Закрыть.TabIndex = 1;
            this.Закрыть.TabStop = false;
            this.Закрыть.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(184, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 86);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::РасписаниеАэропорт.Поляков.Properties.Resources.ФонЗагрузки;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // НижняяПанель
            // 
            this.НижняяПанель.BackColor = System.Drawing.Color.SteelBlue;
            this.НижняяПанель.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.НижняяПанель.Controls.Add(this.progressBar1);
            this.НижняяПанель.Controls.Add(this.panel1);
            this.НижняяПанель.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НижняяПанель.Location = new System.Drawing.Point(-5, 319);
            this.НижняяПанель.Name = "НижняяПанель";
            this.НижняяПанель.Size = new System.Drawing.Size(494, 101);
            this.НижняяПанель.TabIndex = 4;
            // 
            // Загрузка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(477, 417);
            this.Controls.Add(this.ВерхняяПанель);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.НижняяПанель);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Загрузка";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авиастрела - Загрузка приложения";
            this.ВерхняяПанель.ResumeLayout(false);
            this.ВерхняяПанель.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Закрыть)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.НижняяПанель.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ЗагрузкаПриложения;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ВерхняяПанель;
        private System.Windows.Forms.PictureBox Закрыть;
        private System.Windows.Forms.Label ЗагрузкаТекст;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel НижняяПанель;
    }
}

