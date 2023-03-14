using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsServiceStationApp.Views.Forms
{
    public partial class UpdateCarForm : Form, ICar, IOwner
    {
        int curretrRowIndexForShow = -1;
        int curMouseOverRow = -1;

        public UpdateCarForm()
        {
            InitializeComponent();
        }

        // интерфейсы
        #region IOwner
        // IOwner
        public int ownerId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FullName_Text { get => fullNameSearchTextBox.Text; set => fullNameSearchTextBox.Text = value; }
        public string Adress_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NumPassport_Text { get => passportSearchTextBox.Text; set => passportSearchTextBox.Text = value; }
        public string Phone_Text { get => phoneSearchTextBox.Text; set => phoneSearchTextBox.Text = value; }
        public byte[] ownerRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object OwnerViewItems_Object
        {
            get => dataGridView6.DataSource;
            set => dataGridView6.UniverseInvoke(() => dataGridView6.DataSource = value);
        }
        //  public int? keyNumOwner_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion 
        #region Icar
        // Icar
        public int CarId_Integer { get; set; }
        public string VIN_Text { get => VINtextBox.Text; set => VINtextBox.Text = value; }
        public string numReg_Text { get => RegNumtextBox.Text; set => RegNumtextBox.Text = value; }
        public string nameBrand_Text { get => BrandtextBox.Text; set => BrandtextBox.Text = value; }
        public string nameModel_Text { get => ModeltextBox.Text; set => ModeltextBox.Text = value; }
        public int? ForeignCarOwnerId_Integer { get; set; }
        public DateTime dateRelease_DateTime { get => YearAutodateTimePicker.Value; set => YearAutodateTimePicker.Value = value; }
        public byte[] carRowVersion_ByteArray { get; set; }
        public object CarViewItems_Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string fullNamecurrentCARowner { get => fullNameOwnertextBox.Text; set => fullNameOwnertextBox.Text = value; }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            if(phoneSearchTextBox.Text.Trim() != "" // если хотя бы одно поле для поиска вбито
                || passportSearchTextBox.Text.Trim() != ""
                    || fullNameSearchTextBox.Text.Trim() != "")
            {
                Presenters.OwnerPresenter ownerPresenter = new Presenters.OwnerPresenter(this);
                ownerPresenter.SearchByManyPatameters();
            }
            else
            {
                dataGridView6.DataSource = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
            label8.Visible = true;
        }

        private void UpdateCarForm_Load(object sender, EventArgs e) => dataGridView6.DoubleBuffered(true);
        private void dataGridView6_MouseDown(object sender, MouseEventArgs e) => dataGridView6.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShow, ref curMouseOverRow);     
        private void dataGridView6_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView6.RowPrePait_UserOverride(e);
        private void dataGridView6_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShow = e.RowIndex;
            dataGridView6.Rows[curretrRowIndexForShow].Selected = true;
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();
        
        private void сделатьВыборВладельцаToolStripMenuItem_Click(object sender, EventArgs e) => ChangeOwnerForCarAsync();
        
        private async void ChangeOwnerForCarAsync()
        {
            if (curretrRowIndexForShow >= 0 && dataGridView6.DataSource != null)
            {
                int selectedKey = (int)dataGridView6.Rows[curretrRowIndexForShow].Cells[5].Value;
                int? lastkey = ForeignCarOwnerId_Integer; // сохраняю старого владельца на случай ошибки

                try
                {
                    ForeignCarOwnerId_Integer = selectedKey;
                    Presenters.CarPresenter carPresenter = new Presenters.CarPresenter(this);
                    await Task.Run(() => { carPresenter.ChangeOwner(); });

                    fullNameOwnertextBox.Text = (string)dataGridView6.Rows[curretrRowIndexForShow].Cells[0].Value; // изменяю имя владельца на нового в текстбоксе
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    ForeignCarOwnerId_Integer = lastkey; // в случае ошибки возвращаю старого владельца в интерфейс
                }
                finally
                {
                    panel1.Enabled = true; // разблокирую панель авто
                    panel2.Enabled = false; // блокирую панель владельца 
                    // чищу поля поиска
                    passportSearchTextBox.Clear();
                    phoneSearchTextBox.Clear();
                    fullNameSearchTextBox.Clear();
                    dataGridView6.DataSource = null;
                    label8.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана! Выберите и повторите снова!");
            }
        }

        private void button1_Click(object sender, EventArgs e) => UpdateCarElemFuncAsync();

        private async void UpdateCarElemFuncAsync()
        {
            Presenters.CarPresenter carPresenter = new Presenters.CarPresenter(this);
            await Task.Run(() => { carPresenter.UpdateCarElem(); });
            this.Close();
        }
    }
}
