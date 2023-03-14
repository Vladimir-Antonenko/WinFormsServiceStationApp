﻿
namespace WinFormsServiceStationApp.Views.Forms
{
    partial class DefaultOrderStateForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stateWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowVersionDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВыбраннуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultOrderStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultOrderStateBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateWorkDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.rowVersionDataGridViewImageColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.defaultOrderStateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.Size = new System.Drawing.Size(182, 244);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // stateWorkDataGridViewTextBoxColumn
            // 
            this.stateWorkDataGridViewTextBoxColumn.DataPropertyName = "StateWork";
            this.stateWorkDataGridViewTextBoxColumn.HeaderText = "Состояние работы";
            this.stateWorkDataGridViewTextBoxColumn.Name = "stateWorkDataGridViewTextBoxColumn";
            this.stateWorkDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.добавитьЗаписьToolStripMenuItem,
            this.изменитьВыбраннуюЗаписьToolStripMenuItem,
            this.удалитьВыбраннуюЗаписьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 70);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // изменитьВыбраннуюЗаписьToolStripMenuItem
            // 
            this.изменитьВыбраннуюЗаписьToolStripMenuItem.Name = "изменитьВыбраннуюЗаписьToolStripMenuItem";
            this.изменитьВыбраннуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.изменитьВыбраннуюЗаписьToolStripMenuItem.Text = "Изменить выбранную запись";
            this.изменитьВыбраннуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.изменитьВыбраннуюЗаписьToolStripMenuItem_Click);
            // 
            // удалитьВыбраннуюЗаписьToolStripMenuItem
            // 
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Name = "удалитьВыбраннуюЗаписьToolStripMenuItem";
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Text = "Удалить выбранную запись";
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраннуюЗаписьToolStripMenuItem_Click);
            // 
            // defaultOrderStateBindingSource
            // 
            this.defaultOrderStateBindingSource.DataSource = typeof(WinFormsServiceStationApp.Models.DefaultOrderState);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(24, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 100);
            this.panel1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(164, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Отмена";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // DefaultOrderStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DefaultOrderStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Значения по умолчанию для статуса заказ-наряда";
            this.Load += new System.EventHandler(this.DefaultOrderStateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultOrderStateBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource defaultOrderStateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn rowVersionDataGridViewImageColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьВыбраннуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}