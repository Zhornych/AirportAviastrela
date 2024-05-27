namespace РасписаниеАэропорт.Поляков
{
    partial class Аккаунт
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Аккаунт));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Закрыть = new System.Windows.Forms.PictureBox();
            this.КнопкаАвторизации = new System.Windows.Forms.Button();
            this.ДопТекст = new System.Windows.Forms.Label();
            this.СкрытьПароль = new System.Windows.Forms.PictureBox();
            this.Логин = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.ФамилияТекст = new System.Windows.Forms.Label();
            this.ИмяТекст = new System.Windows.Forms.Label();
            this.НазваниеФормы = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Закрыть)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкрытьПароль)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Закрыть);
            this.panel1.Controls.Add(this.КнопкаАвторизации);
            this.panel1.Controls.Add(this.ДопТекст);
            this.panel1.Controls.Add(this.СкрытьПароль);
            this.panel1.Controls.Add(this.Логин);
            this.panel1.Controls.Add(this.Пароль);
            this.panel1.Controls.Add(this.ФамилияТекст);
            this.panel1.Controls.Add(this.ИмяТекст);
            this.panel1.Controls.Add(this.НазваниеФормы);
            this.panel1.Location = new System.Drawing.Point(466, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 475);
            this.panel1.TabIndex = 0;
            // 
            // Закрыть
            // 
            this.Закрыть.BackColor = System.Drawing.Color.SteelBlue;
            this.Закрыть.Image = ((System.Drawing.Image)(resources.GetObject("Закрыть.Image")));
            this.Закрыть.Location = new System.Drawing.Point(291, 11);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(37, 31);
            this.Закрыть.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Закрыть.TabIndex = 14;
            this.Закрыть.TabStop = false;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // КнопкаАвторизации
            // 
            this.КнопкаАвторизации.BackColor = System.Drawing.Color.LightSkyBlue;
            this.КнопкаАвторизации.Cursor = System.Windows.Forms.Cursors.Hand;
            this.КнопкаАвторизации.ForeColor = System.Drawing.Color.MidnightBlue;
            this.КнопкаАвторизации.Location = new System.Drawing.Point(95, 320);
            this.КнопкаАвторизации.Name = "КнопкаАвторизации";
            this.КнопкаАвторизации.Size = new System.Drawing.Size(152, 43);
            this.КнопкаАвторизации.TabIndex = 13;
            this.КнопкаАвторизации.Text = "Авторизация";
            this.КнопкаАвторизации.UseVisualStyleBackColor = false;
            this.КнопкаАвторизации.Click += new System.EventHandler(this.КнопкаАвторизации_Click);
            // 
            // ДопТекст
            // 
            this.ДопТекст.AutoSize = true;
            this.ДопТекст.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДопТекст.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ДопТекст.Location = new System.Drawing.Point(57, 112);
            this.ДопТекст.Name = "ДопТекст";
            this.ДопТекст.Size = new System.Drawing.Size(228, 36);
            this.ДопТекст.TabIndex = 8;
            this.ДопТекст.Text = "Авторизируйтесь в приложении\r\n     для полного функционала\r\n";
            // 
            // СкрытьПароль
            // 
            this.СкрытьПароль.Cursor = System.Windows.Forms.Cursors.Hand;
            this.СкрытьПароль.Image = global::РасписаниеАэропорт.Поляков.Properties.Resources.ПарольСкрыт;
            this.СкрытьПароль.Location = new System.Drawing.Point(277, 234);
            this.СкрытьПароль.Name = "СкрытьПароль";
            this.СкрытьПароль.Size = new System.Drawing.Size(21, 20);
            this.СкрытьПароль.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.СкрытьПароль.TabIndex = 12;
            this.СкрытьПароль.TabStop = false;
            this.СкрытьПароль.Click += new System.EventHandler(this.СкрытьПароль_Click);
            // 
            // Логин
            // 
            this.Логин.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Логин.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Логин.Location = new System.Drawing.Point(128, 187);
            this.Логин.MaxLength = 11;
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(143, 21);
            this.Логин.TabIndex = 10;
            // 
            // Пароль
            // 
            this.Пароль.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Пароль.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.Location = new System.Drawing.Point(128, 234);
            this.Пароль.MaxLength = 11;
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(143, 21);
            this.Пароль.TabIndex = 11;
            this.Пароль.Enter += new System.EventHandler(this.Пароль_Enter);
            this.Пароль.Leave += new System.EventHandler(this.Пароль_Leave);
            // 
            // ФамилияТекст
            // 
            this.ФамилияТекст.AutoSize = true;
            this.ФамилияТекст.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ФамилияТекст.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ФамилияТекст.Location = new System.Drawing.Point(39, 235);
            this.ФамилияТекст.Name = "ФамилияТекст";
            this.ФамилияТекст.Size = new System.Drawing.Size(65, 18);
            this.ФамилияТекст.TabIndex = 9;
            this.ФамилияТекст.Text = "Пароль:";
            // 
            // ИмяТекст
            // 
            this.ИмяТекст.AutoSize = true;
            this.ИмяТекст.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ИмяТекст.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ИмяТекст.Location = new System.Drawing.Point(45, 190);
            this.ИмяТекст.Name = "ИмяТекст";
            this.ИмяТекст.Size = new System.Drawing.Size(54, 18);
            this.ИмяТекст.TabIndex = 8;
            this.ИмяТекст.Text = "Логин:";
            // 
            // НазваниеФормы
            // 
            this.НазваниеФормы.AutoSize = true;
            this.НазваниеФормы.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.НазваниеФормы.ForeColor = System.Drawing.Color.DarkBlue;
            this.НазваниеФормы.Location = new System.Drawing.Point(56, 50);
            this.НазваниеФормы.Name = "НазваниеФормы";
            this.НазваниеФормы.Size = new System.Drawing.Size(224, 48);
            this.НазваниеФормы.TabIndex = 4;
            this.НазваниеФормы.Text = "Авторизация\r\n   для диспетчеров";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::РасписаниеАэропорт.Поляков.Properties.Resources.ФонАвторизация;
            this.pictureBox1.Location = new System.Drawing.Point(-89, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Аккаунт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Аккаунт";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Закрыть)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкрытьПароль)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label НазваниеФормы;
        private System.Windows.Forms.TextBox Логин;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.Label ФамилияТекст;
        private System.Windows.Forms.Label ИмяТекст;
        private System.Windows.Forms.PictureBox СкрытьПароль;
        private System.Windows.Forms.Label ДопТекст;
        private System.Windows.Forms.Button КнопкаАвторизации;
        private System.Windows.Forms.PictureBox Закрыть;
    }
}