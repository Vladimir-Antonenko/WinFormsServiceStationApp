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
    public partial class UpdateOwnerForm : Form, IOwner
    {
        public UpdateOwnerForm()
        {
            InitializeComponent();
        }

        // интерфейсы
        #region IOwner
        // IOwner
        public int ownerId_Integer { get; set; }
        public string FullName_Text { get => fioTextBox.Text; set => fioTextBox.Text = value; }
        public string Adress_Text { get => adressTextBox.Text; set => adressTextBox.Text = value; }
        public string NumPassport_Text { get => numPasstortTextBox.Text; set => numPasstortTextBox.Text = value; }
        public string Phone_Text { get => phoneTextBox.Text; set => phoneTextBox.Text = value; }
      //  public List<object> Cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] ownerRowVersion_ByteArray { get; set; }
        public object OwnerViewItems_Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // public int? keyNumOwner_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        private void saveChangeButton_Click(object sender, EventArgs e) => UpdateOwnerElemFunc();
        private void cancelButton_Click(object sender, EventArgs e) => this.Close();

        private async void UpdateOwnerElemFunc()
        {
            Presenters.OwnerPresenter ownerPresenter = new OwnerPresenter(this);
            await Task.Run(() => { ownerPresenter.UpdateOwnerElem(); });
            this.Close();
        }
    }
}
