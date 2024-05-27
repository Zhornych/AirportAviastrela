
namespace РасписаниеАэропорт.Поляков
{
    partial class АдминФорма
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ВерхняяПанель = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ИзображениеВыход = new System.Windows.Forms.PictureBox();
            this.НазваниеФормы = new System.Windows.Forms.Label();
            this.ФонДобавление = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ДобавлениеДанных = new System.Windows.Forms.Label();
            this.Добавить = new System.Windows.Forms.Button();
            this.Пароль = new System.Windows.Forms.TextBox();
            this.Логин = new System.Windows.Forms.TextBox();
            this.МестоТекст = new System.Windows.Forms.Label();
            this.БДДиспетчеры = new System.Windows.Forms.DataGridView();
            this.логинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диспетчерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бДДиспетчеры1 = new РасписаниеАэропорт.Поляков.БДДиспетчеры();
            this.диспетчерыTableAdapter = new РасписаниеАэропорт.Поляков.БДДиспетчерыTableAdapters.ДиспетчерыTableAdapter();
            this.УдалениеКнопка = new System.Windows.Forms.Button();
            this.ФонБД = new System.Windows.Forms.Panel();
            this.ВерхняяПанель.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ИзображениеВыход)).BeginInit();
            this.ФонДобавление.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.БДДиспетчеры)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диспетчерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДДиспетчеры1)).BeginInit();
            this.ФонБД.SuspendLayout();
            this.SuspendLayout();
            // 
            // ВерхняяПанель
            // 
            this.ВерхняяПанель.BackColor = System.Drawing.SystemColors.Control;
            this.ВерхняяПанель.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ВерхняяПанель.Controls.Add(this.panel1);
            this.ВерхняяПанель.Controls.Add(this.ИзображениеВыход);
            this.ВерхняяПанель.Controls.Add(this.НазваниеФормы);
            this.ВерхняяПанель.Location = new System.Drawing.Point(-15, -4);
            this.ВерхняяПанель.Name = "ВерхняяПанель";
            this.ВерхняяПанель.Size = new System.Drawing.Size(591, 52);
            this.ВерхняяПанель.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(25, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 88);
            this.panel1.TabIndex = 19;
            // 
            // ИзображениеВыход
            // 
            this.ИзображениеВыход.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ИзображениеВыход.Image = global::РасписаниеАэропорт.Поляков.Properties.Resources.Закрыть;
            this.ИзображениеВыход.Location = new System.Drawing.Point(527, 7);
            this.ИзображениеВыход.Name = "ИзображениеВыход";
            this.ИзображениеВыход.Size = new System.Drawing.Size(40, 40);
            this.ИзображениеВыход.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ИзображениеВыход.TabIndex = 2;
            this.ИзображениеВыход.TabStop = false;
            this.ИзображениеВыход.Click += new System.EventHandler(this.ИзображениеВыход_Click);
            // 
            // НазваниеФормы
            // 
            this.НазваниеФормы.AutoSize = true;
            this.НазваниеФормы.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.НазваниеФормы.ForeColor = System.Drawing.Color.DarkBlue;
            this.НазваниеФормы.Location = new System.Drawing.Point(29, 12);
            this.НазваниеФормы.Name = "НазваниеФормы";
            this.НазваниеФормы.Size = new System.Drawing.Size(330, 24);
            this.НазваниеФормы.TabIndex = 21;
            this.НазваниеФормы.Text = "Добавление нового диспетчера";
            // 
            // ФонДобавление
            // 
            this.ФонДобавление.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ФонДобавление.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ФонДобавление.Controls.Add(this.label1);
            this.ФонДобавление.Controls.Add(this.ДобавлениеДанных);
            this.ФонДобавление.Controls.Add(this.Добавить);
            this.ФонДобавление.Controls.Add(this.Пароль);
            this.ФонДобавление.Controls.Add(this.Логин);
            this.ФонДобавление.Controls.Add(this.МестоТекст);
            this.ФонДобавление.Location = new System.Drawing.Point(287, 72);
            this.ФонДобавление.Name = "ФонДобавление";
            this.ФонДобавление.Size = new System.Drawing.Size(266, 128);
            this.ФонДобавление.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пароль";
            // 
            // ДобавлениеДанных
            // 
            this.ДобавлениеДанных.AutoSize = true;
            this.ДобавлениеДанных.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДобавлениеДанных.ForeColor = System.Drawing.Color.Black;
            this.ДобавлениеДанных.Location = new System.Drawing.Point(61, 3);
            this.ДобавлениеДанных.Name = "ДобавлениеДанных";
            this.ДобавлениеДанных.Size = new System.Drawing.Size(156, 16);
            this.ДобавлениеДанных.TabIndex = 10;
            this.ДобавлениеДанных.Text = "Добавление данных";
            // 
            // Добавить
            // 
            this.Добавить.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Добавить.ForeColor = System.Drawing.Color.Black;
            this.Добавить.Location = new System.Drawing.Point(58, 95);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(158, 23);
            this.Добавить.TabIndex = 9;
            this.Добавить.Text = "Добавить диспетчера";
            this.Добавить.UseVisualStyleBackColor = true;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Пароль
            // 
            this.Пароль.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Пароль.Location = new System.Drawing.Point(94, 59);
            this.Пароль.MaxLength = 10;
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(100, 20);
            this.Пароль.TabIndex = 7;
            // 
            // Логин
            // 
            this.Логин.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Логин.Location = new System.Drawing.Point(94, 33);
            this.Логин.MaxLength = 10;
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(100, 20);
            this.Логин.TabIndex = 7;
            // 
            // МестоТекст
            // 
            this.МестоТекст.AutoSize = true;
            this.МестоТекст.ForeColor = System.Drawing.Color.Black;
            this.МестоТекст.Location = new System.Drawing.Point(49, 36);
            this.МестоТекст.Name = "МестоТекст";
            this.МестоТекст.Size = new System.Drawing.Size(38, 13);
            this.МестоТекст.TabIndex = 1;
            this.МестоТекст.Text = "Логин";
            // 
            // БДДиспетчеры
            // 
            this.БДДиспетчеры.AllowUserToAddRows = false;
            this.БДДиспетчеры.AllowUserToDeleteRows = false;
            this.БДДиспетчеры.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.БДДиспетчеры.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.БДДиспетчеры.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.БДДиспетчеры.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.логинDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn});
            this.БДДиспетчеры.Cursor = System.Windows.Forms.Cursors.Hand;
            this.БДДиспетчеры.DataSource = this.диспетчерыBindingSource;
            this.БДДиспетчеры.EnableHeadersVisualStyles = false;
            this.БДДиспетчеры.Location = new System.Drawing.Point(14, 10);
            this.БДДиспетчеры.Name = "БДДиспетчеры";
            this.БДДиспетчеры.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.БДДиспетчеры.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.БДДиспетчеры.Size = new System.Drawing.Size(243, 275);
            this.БДДиспетчеры.TabIndex = 24;
            // 
            // логинDataGridViewTextBoxColumn
            // 
            this.логинDataGridViewTextBoxColumn.DataPropertyName = "Логин";
            this.логинDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.логинDataGridViewTextBoxColumn.Name = "логинDataGridViewTextBoxColumn";
            this.логинDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // диспетчерыBindingSource
            // 
            this.диспетчерыBindingSource.DataMember = "Диспетчеры";
            this.диспетчерыBindingSource.DataSource = this.бДДиспетчеры1;
            // 
            // бДДиспетчеры1
            // 
            this.бДДиспетчеры1.DataSetName = "БДДиспетчеры";
            this.бДДиспетчеры1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // диспетчерыTableAdapter
            // 
            this.диспетчерыTableAdapter.ClearBeforeFill = true;
            // 
            // УдалениеКнопка
            // 
            this.УдалениеКнопка.Cursor = System.Windows.Forms.Cursors.Hand;
            this.УдалениеКнопка.ForeColor = System.Drawing.Color.DarkRed;
            this.УдалениеКнопка.Location = new System.Drawing.Point(287, 224);
            this.УдалениеКнопка.Name = "УдалениеКнопка";
            this.УдалениеКнопка.Size = new System.Drawing.Size(266, 23);
            this.УдалениеКнопка.TabIndex = 9;
            this.УдалениеКнопка.Text = "Удалить выделенного диспетчера";
            this.УдалениеКнопка.UseVisualStyleBackColor = true;
            this.УдалениеКнопка.Click += new System.EventHandler(this.Удаление_Click);
            // 
            // ФонБД
            // 
            this.ФонБД.BackColor = System.Drawing.Color.SteelBlue;
            this.ФонБД.Controls.Add(this.БДДиспетчеры);
            this.ФонБД.Location = new System.Drawing.Point(-2, 45);
            this.ФонБД.Name = "ФонБД";
            this.ФонБД.Size = new System.Drawing.Size(274, 304);
            this.ФонБД.TabIndex = 25;
            // 
            // АдминФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(565, 342);
            this.ControlBox = false;
            this.Controls.Add(this.ВерхняяПанель);
            this.Controls.Add(this.ФонБД);
            this.Controls.Add(this.ФонДобавление);
            this.Controls.Add(this.УдалениеКнопка);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "АдминФорма";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АдминФорма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.АдминФорма_FormClosed);
            this.Load += new System.EventHandler(this.АдминФорма_Load);
            this.ВерхняяПанель.ResumeLayout(false);
            this.ВерхняяПанель.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ИзображениеВыход)).EndInit();
            this.ФонДобавление.ResumeLayout(false);
            this.ФонДобавление.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.БДДиспетчеры)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диспетчерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бДДиспетчеры1)).EndInit();
            this.ФонБД.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ВерхняяПанель;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ИзображениеВыход;
        private System.Windows.Forms.Label НазваниеФормы;
        private System.Windows.Forms.Panel ФонДобавление;
        private System.Windows.Forms.Label ДобавлениеДанных;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.TextBox Логин;
        private System.Windows.Forms.Label МестоТекст;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Пароль;
        private System.Windows.Forms.DataGridView БДДиспетчеры;
        private БДДиспетчеры бДДиспетчеры1;
        private System.Windows.Forms.BindingSource диспетчерыBindingSource;
        private БДДиспетчерыTableAdapters.ДиспетчерыTableAdapter диспетчерыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button УдалениеКнопка;
        private System.Windows.Forms.Panel ФонБД;
    }
}