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
    public partial class AddWorkerForm : Form, IWorker, IDefaultRole
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }
        // интерфейсы
        #region IWorker
        public int wId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string wFullName_Text 
        { 
            get => fullNameWorkerTextBox.Text; 
            set => fullNameWorkerTextBox.Text = value; 
        }
        public string wPhone_Text 
        { 
            get => phoneTextBox.Text; 
            set => phoneTextBox.Text = value; 
        }
        public string wNumPassport_Text 
        { 
            get => numPasstortTextBox.Text; 
            set => numPasstortTextBox.Text = value; 
        }
        public int? wDefaultRoleId_Integer 
        { 
            get => (int?)comboBox1.SelectedValue; 
            set => comboBox1.SelectedValue = value; 
        }
        public byte[] workerRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object WorkerViewItems 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        public object wOrderViewAcceptorsItems_Object
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        #endregion
        #region IDefaultRole
        public int roleId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string NameSpeciality_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object roleList_Object 
        { 
            get => comboBox1.DataSource; 
            set => comboBox1.UniverseInvoke(() => comboBox1.DataSource = value);
        }
        public byte[] roleRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        #endregion

        private void cancelButton_Click(object sender, EventArgs e) => Close();

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (numPasstortTextBox.Text != "")
                AddWorkerElemFunc();
            else
                MessageBox.Show("Введите номер паспорта и попробуйте ещё раз!");
        }
        private async void AddWorkerElemFunc()
        {
            try
            {
                WorkerPresenter workerPresenter = new WorkerPresenter(this);
                await Task.Run(() => { workerPresenter.AddWorkerElem(); });
                this.Close();
            }  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            DefaultRolePresenter rolePresenter = new DefaultRolePresenter(this);
            rolePresenter.GetDefaultRoleTable();
        }
    }
}
