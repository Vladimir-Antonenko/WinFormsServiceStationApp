
namespace WinFormsServiceStationApp.Views.Forms
{
    partial class AddCarForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.VINtextBox = new System.Windows.Forms.TextBox();
            this.BrandtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.RegNumtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearAutodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numPassportOwnertextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить в таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VINtextBox
            // 
            this.VINtextBox.Location = new System.Drawing.Point(135, 16);
            this.VINtextBox.Name = "VINtextBox";
            this.VINtextBox.Size = new System.Drawing.Size(121, 20);
            this.VINtextBox.TabIndex = 1;
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
            // ModeltextBox
            // 
            this.ModeltextBox.Location = new System.Drawing.Point(135, 102);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(121, 20);
            this.ModeltextBox.TabIndex = 7;
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
            // YearAutodateTimePicker
            // 
            this.YearAutodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearAutodateTimePicker.Location = new System.Drawing.Point(135, 194);
            this.YearAutodateTimePicker.Name = "YearAutodateTimePicker";
            this.YearAutodateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.YearAutodateTimePicker.TabIndex = 12;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Поля отмеченные * обязательны к заполнению";
            // 
            // numPassportOwnertextBox
            // 
            this.numPassportOwnertextBox.Location = new System.Drawing.Point(136, 15);
            this.numPassportOwnertextBox.Name = "numPassportOwnertextBox";
            this.numPassportOwnertextBox.Size = new System.Drawing.Size(143, 20);
            this.numPassportOwnertextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Паспорт владельца*";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Проверить владельца в таблице владельцы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VINtextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BrandtextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ModeltextBox);
            this.panel1.Controls.Add(this.YearAutodateTimePicker);
            this.panel1.Controls.Add(this.RegNumtextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(23, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 275);
            this.panel1.TabIndex = 19;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPassportOwnertextBox);
            this.Controls.Add(this.label5);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового автомобиля";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VINtextBox;
        private System.Windows.Forms.TextBox BrandtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModeltextBox;
        private System.Windows.Forms.TextBox RegNumtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker YearAutodateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numPassportOwnertextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}