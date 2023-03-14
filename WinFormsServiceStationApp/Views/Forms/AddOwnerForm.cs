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
    public partial class AddOwnerForm : Form, IOwner
    {
        public AddOwnerForm()
        {
            InitializeComponent();
        }

        // интерфейсы
        #region IOwner
        public int ownerId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string FullName_Text 
        { 
            get => fioTextBox.Text; 
            set => fioTextBox.Text = value; 
        }
        public string Adress_Text 
        {
            get => adressTextBox.Text; 
            set => adressTextBox.Text = value; 
        }
        public string NumPassport_Text 
        { 
            get => numPasstortTextBox.Text; 
            set => numPasstortTextBox.Text = value; 
        }
        public string Phone_Text 
        { 
            get => phoneTextBox.Text; 
            set => phoneTextBox.Text = value; 
        }

        public byte[] ownerRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object OwnerViewItems_Object 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        #endregion

        private void saveButton_Click(object sender, EventArgs e) => AddOwnerElemFunc();
        private void cancelButton_Click(object sender, EventArgs e) => this.Close();

        private async void AddOwnerElemFunc()
        {
            try
            {
                OwnerPresenter ownerPresenter = new OwnerPresenter(this);
                await Task.Run(() => { ownerPresenter.AddOwnerElem(); });
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
