
namespace WinFormsServiceStationApp.Views.Forms
{
    partial class ChoiceCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceCarForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.VINSearchTextBox = new System.Windows.Forms.TextBox();
            this.regNumSearchTextBox = new System.Windows.Forms.TextBox();
            this.brandSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelSearchTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReleaseDataGridViewTextBoxColumn = new System.Windows.Forms.CalendarColumn();
            this.ownerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.modelSearchTextBox);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridView6);
            this.panel2.Controls.Add(this.VINSearchTextBox);
            this.panel2.Controls.Add(this.regNumSearchTextBox);
            this.panel2.Controls.Add(this.brandSearchTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 351);
            this.panel2.TabIndex = 27;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(264, 205);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(118, 59);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Искать автомобиль по параметрам";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 65);
            this.label8.TabIndex = 25;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "VIN/№кузова";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Гос. номер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Марка авто";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vINDataGridViewTextBoxColumn,
            this.numRegDataGridViewTextBoxColumn,
            this.nameBrandDataGridViewTextBoxColumn,
            this.nameModelDataGridViewTextBoxColumn,
            this.dateReleaseDataGridViewTextBoxColumn,
            this.ownerIdDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.rowVersionDataGridViewImageColumn});
            this.dataGridView6.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView6.DataSource = this.carBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(18, 21);
            this.dataGridView6.MultiSelect = false;
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersWidth = 80;
            this.dataGridView6.Size = new System.Drawing.Size(683, 174);
            this.dataGridView6.TabIndex = 7;
            this.dataGridView6.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_RowEnter);
            this.dataGridView6.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView6_RowPrePaint_1);
            this.dataGridView6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView6_MouseDown);
            // 
            // VINSearchTextBox
            // 
            this.VINSearchTextBox.Location = new System.Drawing.Point(117, 205);
            this.VINSearchTextBox.Name = "VINSearchTextBox";
            this.VINSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.VINSearchTextBox.TabIndex = 2;
            // 
            // regNumSearchTextBox
            // 
            this.regNumSearchTextBox.Location = new System.Drawing.Point(117, 231);
            this.regNumSearchTextBox.Name = "regNumSearchTextBox";
            this.regNumSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.regNumSearchTextBox.TabIndex = 1;
            // 
            // brandSearchTextBox
            // 
            this.brandSearchTextBox.Location = new System.Drawing.Point(117, 257);
            this.brandSearchTextBox.Name = "brandSearchTextBox";
            this.brandSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.brandSearchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Модель авто";
            // 
            // modelSearchTextBox
            // 
            this.modelSearchTextBox.Location = new System.Drawing.Point(117, 283);
            this.modelSearchTextBox.Name = "modelSearchTextBox";
            this.modelSearchTextBox.Size = new System.Drawing.Size(118, 20);
            this.modelSearchTextBox.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(353, 26);
            // 
            // выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem
            // 
            this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem.Name = "выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem";
            this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem.Size = new System.Drawing.Size(352, 22);
            this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem.Text = "Выбрать автомобиль и добавить его в заказ-наряд";
            this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem.Click += new System.EventHandler(this.выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "В таблице приведены только автомобили с владельцами";
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN/№кузова";
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            this.vINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numRegDataGridViewTextBoxColumn
            // 
            this.numRegDataGridViewTextBoxColumn.DataPropertyName = "NumReg";
            this.numRegDataGridViewTextBoxColumn.HeaderText = "Гос номер";
            this.numRegDataGridViewTextBoxColumn.Name = "numRegDataGridViewTextBoxColumn";
            this.numRegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameBrandDataGridViewTextBoxColumn
            // 
            this.nameBrandDataGridViewTextBoxColumn.DataPropertyName = "NameBrand";
            this.nameBrandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.nameBrandDataGridViewTextBoxColumn.Name = "nameBrandDataGridViewTextBoxColumn";
            this.nameBrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameModelDataGridViewTextBoxColumn
            // 
            this.nameModelDataGridViewTextBoxColumn.DataPropertyName = "NameModel";
            this.nameModelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.nameModelDataGridViewTextBoxColumn.Name = "nameModelDataGridViewTextBoxColumn";
            this.nameModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReleaseDataGridViewTextBoxColumn
            // 
            this.dateReleaseDataGridViewTextBoxColumn.DataPropertyName = "DateRelease";
            dataGridViewCellStyle1.Format = "yyyy";
            this.dateReleaseDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateReleaseDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.dateReleaseDataGridViewTextBoxColumn.Name = "dateReleaseDataGridViewTextBoxColumn";
            this.dateReleaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateReleaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateReleaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            this.ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            this.ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            this.ownerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Владелец";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.Car);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(601, 208);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 29;
            // 
            // ChoiceCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 371);
            this.Controls.Add(this.panel2);
            this.Name = "ChoiceCarForm";
            this.Text = "Выбор автомобиля";
            this.Load += new System.EventHandler(this.ChoiceCarForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TextBox VINSearchTextBox;
        private System.Windows.Forms.TextBox regNumSearchTextBox;
        private System.Windows.Forms.TextBox brandSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.CalendarColumn dateReleaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modelSearchTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}