
namespace WinFormsServiceStationApp.Views.Forms
{
    partial class UpdateCarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.VINtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BrandtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.YearAutodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegNumtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fullNameOwnertextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сделатьВыборВладельцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportSearchTextBox = new System.Windows.Forms.TextBox();
            this.fullNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.phoneSearchTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VINtextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BrandtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ModeltextBox);
            this.panel1.Controls.Add(this.YearAutodateTimePicker);
            this.panel1.Controls.Add(this.RegNumtextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 275);
            this.panel1.TabIndex = 24;
            // 
            // VINtextBox
            // 
            this.VINtextBox.Location = new System.Drawing.Point(135, 16);
            this.VINtextBox.Name = "VINtextBox";
            this.VINtextBox.ReadOnly = true;
            this.VINtextBox.Size = new System.Drawing.Size(121, 20);
            this.VINtextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrandtextBox
            // 
            this.BrandtextBox.Location = new System.Drawing.Point(135, 58);
            this.BrandtextBox.Name = "BrandtextBox";
            this.BrandtextBox.Size = new System.Drawing.Size(121, 20);
            this.BrandtextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIN/№кузова*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Марка авто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Модель авто";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Год выпуска авто";
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Location = new System.Drawing.Point(135, 102);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(121, 20);
            this.ModeltextBox.TabIndex = 7;
            // 
            // YearAutodateTimePicker
            // 
            this.YearAutodateTimePicker.CustomFormat = "yyyy";
            this.YearAutodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearAutodateTimePicker.Location = new System.Drawing.Point(135, 194);
            this.YearAutodateTimePicker.Name = "YearAutodateTimePicker";
            this.YearAutodateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.YearAutodateTimePicker.TabIndex = 12;
            // 
            // RegNumtextBox
            // 
            this.RegNumtextBox.Location = new System.Drawing.Point(135, 145);
            this.RegNumtextBox.Name = "RegNumtextBox";
            this.RegNumtextBox.Size = new System.Drawing.Size(121, 20);
            this.RegNumtextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Гос. номер";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Сменить владельца";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ФИО владельца";
            // 
            // fullNameOwnertextBox
            // 
            this.fullNameOwnertextBox.Location = new System.Drawing.Point(131, 34);
            this.fullNameOwnertextBox.Name = "fullNameOwnertextBox";
            this.fullNameOwnertextBox.ReadOnly = true;
            this.fullNameOwnertextBox.Size = new System.Drawing.Size(143, 20);
            this.fullNameOwnertextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Поля отмеченные * обязательны к заполнению";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 65);
            this.label8.TabIndex = 25;
            this.label8.Text = "Воспользуйтесь полями для поиска владельцев, \r\nимеющихся в таблице Владельцы. Зат" +
    "ем выберите\r\nподходящего.\r\nВ случае отсутствия - предварительно добавьте\r\n и пов" +
    "торите процедуру поиска.";
            this.label8.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridView6);
            this.panel2.Controls.Add(this.passportSearchTextBox);
            this.panel2.Controls.Add(this.fullNameSearchTextBox);
            this.panel2.Controls.Add(this.phoneSearchTextBox);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(304, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 351);
            this.panel2.TabIndex = 26;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(274, 208);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 59);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Искать владельца по параметрам";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "№паспорта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "ФИО";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Телефон";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.numPassportDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.carsDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.rowVersionDataGridViewImageColumn});
            this.dataGridView6.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView6.DataSource = this.ownerBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(6, 8);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersWidth = 80;
            this.dataGridView6.Size = new System.Drawing.Size(482, 174);
            this.dataGridView6.TabIndex = 7;
            this.dataGridView6.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_RowEnter);
            this.dataGridView6.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView6_RowPrePaint);
            this.dataGridView6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView6_MouseDown);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО владельца";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numPassportDataGridViewTextBoxColumn
            // 
            this.numPassportDataGridViewTextBoxColumn.DataPropertyName = "NumPassport";
            this.numPassportDataGridViewTextBoxColumn.HeaderText = "№паспорта";
            this.numPassportDataGridViewTextBoxColumn.Name = "numPassportDataGridViewTextBoxColumn";
            this.numPassportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsDataGridViewTextBoxColumn
            // 
            this.carsDataGridViewTextBoxColumn.DataPropertyName = "Cars";
            this.carsDataGridViewTextBoxColumn.HeaderText = "Cars";
            this.carsDataGridViewTextBoxColumn.Name = "carsDataGridViewTextBoxColumn";
            this.carsDataGridViewTextBoxColumn.ReadOnly = true;
            this.carsDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // rowVersionDataGridViewImageColumn
            // 
            this.rowVersionDataGridViewImageColumn.DataPropertyName = "RowVersion";
            this.rowVersionDataGridViewImageColumn.HeaderText = "RowVersion";
            this.rowVersionDataGridViewImageColumn.Name = "rowVersionDataGridViewImageColumn";
            this.rowVersionDataGridViewImageColumn.ReadOnly = true;
            this.rowVersionDataGridViewImageColumn.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьВыборВладельцаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(284, 26);
            // 
            // сделатьВыборВладельцаToolStripMenuItem
            // 
            this.сделатьВыборВладельцаToolStripMenuItem.Name = "сделатьВыборВладельцаToolStripMenuItem";
            this.сделатьВыборВладельцаToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.сделатьВыборВладельцаToolStripMenuItem.Text = "Выбрать в качестве нового владельца";
            this.сделатьВыборВладельцаToolStripMenuItem.Click += new System.EventHandler(this.сделатьВыборВладельцаToolStripMenuItem_Click);
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.Owner);
            // 
            // passportSearchTextBox
            // 
            this.passportSearchTextBox.Location = new System.Drawing.Point(117, 205);
            this.passportSearchTextBox.Name = "passportSearchTextBox";
            this.passportSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.passportSearchTextBox.TabIndex = 2;
            // 
            // fullNameSearchTextBox
            // 
            this.fullNameSearchTextBox.Location = new System.Drawing.Point(117, 231);
            this.fullNameSearchTextBox.Name = "fullNameSearchTextBox";
            this.fullNameSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.fullNameSearchTextBox.TabIndex = 1;
            // 
            // phoneSearchTextBox
            // 
            this.phoneSearchTextBox.Location = new System.Drawing.Point(117, 257);
            this.phoneSearchTextBox.Name = "phoneSearchTextBox";
            this.phoneSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.phoneSearchTextBox.TabIndex = 0;
            // 
            // UpdateCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fullNameOwnertextBox);
            this.Controls.Add(this.label5);
            this.Name = "UpdateCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить данные об автомобиле";
            this.Load += new System.EventHandler(this.UpdateCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox VINtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BrandtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.DateTimePicker YearAutodateTimePicker;
        private System.Windows.Forms.TextBox RegNumtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fullNameOwnertextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passportSearchTextBox;
        private System.Windows.Forms.TextBox fullNameSearchTextBox;
        private System.Windows.Forms.TextBox phoneSearchTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource ownerBindingSource;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сделатьВыборВладельцаToolStripMenuItem;
    }
}