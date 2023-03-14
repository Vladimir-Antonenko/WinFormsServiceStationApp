using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsServiceStationApp.Presenters;

namespace WinFormsServiceStationApp.Views.Forms
{
    public partial class AddWorkForm : Form, IWork
    {
        public AddWorkForm()
        {
            InitializeComponent();
        }

        // интерфейсы
        #region IWork
        /// <summary>
        /// /////////////
        /// </summary>
        //IWork
        public int workId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string nameWorks_Text 
        {
            get => NameWorkTextBox.Text; 
            set => NameWorkTextBox.Text = value; 
        }
        public double price_Double 
        { 
            get => (double)numericUpDown1.Value; 
            set => numericUpDown1.Value = (decimal)value; 
        }
        public object WorkList_Object 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public byte[] workRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object WorkListLISTBOX_Object 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        //public object myWorks_getget 
        //{ 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}
        #endregion

        private void AddWorkForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown1.Minimum = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (NameWorkTextBox.Text != "")
                AddWorkElemFunc();
            else
                MessageBox.Show("Введите название работы и попробуйте ещё раз!");
        }

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();

        private async void AddWorkElemFunc()
        {
            try
            {
                WorkPresenter workPresenter = new WorkPresenter(this);
                await Task.Run(() => { workPresenter.AddWorkElem(); });
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
