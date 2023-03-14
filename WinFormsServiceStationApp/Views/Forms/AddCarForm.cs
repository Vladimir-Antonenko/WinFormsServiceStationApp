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
    public partial class AddCarForm : Form, ICar, IOwner
    {
        // интерфейсы
        #region ICar
        /// <summary>
        /// ///
        /// </summary>
        // ICar
        public int CarId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string VIN_Text 
        { 
            get => VINtextBox.Text; 
            set => VINtextBox.Text = value; 
        }
        public string numReg_Text 
        { 
            get => RegNumtextBox.Text; 
            set => RegNumtextBox.Text = value; 
        }
        public string nameBrand_Text 
        { 
            get => BrandtextBox.Text; 
            set => BrandtextBox.Text = value; 
        }
        public string nameModel_Text 
        { 
            get => ModeltextBox.Text; 
            set => ModeltextBox.Text = value; 
        } 
        public DateTime dateRelease_DateTime 
        { 
            get => YearAutodateTimePicker.Value; 
            set => YearAutodateTimePicker.Value = value; 
        }
        public byte[] carRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public int? ForeignCarOwnerId_Integer { get; set; }

        public object CarViewItems_Object 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        #endregion
        #region IOwner
        /// <summary>
        /// //
        /// </summary>
        // IOwner
        public int ownerId_Integer
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string FullName_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string Adress_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string NumPassport_Text 
        { 
            get => numPassportOwnertextBox.Text; 
            set => numPassportOwnertextBox.Text = value; 
        }
        public string Phone_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
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

        /// <summary>
        /// ////////////////////////
        /// </summary>
        #endregion

        public AddCarForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();
        private void button1_Click(object sender, EventArgs e) => ButtonAddCar();

        private async void ButtonAddCar()
        {
            if (VINtextBox.Text.Trim() == string.Empty)
                MessageBox.Show("Поле VIN/№кузова обязательно к заполнению!");
            else
            {
                try
                {
                    CarPresenter carPresenter = new CarPresenter(this);
                    await Task.Run(() => { carPresenter.AddCarElem(); });
                    this.Close(); // закрываем форму после добавления
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(numPassportOwnertextBox.Text != "")
            {
                OwnerPresenter ownerPresener = new OwnerPresenter(this);
                int? ownerid = ownerPresener.FindOwner();
                if (ownerid != null) // если нашли владельца в таблице, дадим добавить ему авто
                {
                    ForeignCarOwnerId_Integer = (int)ownerid; ; // инициализирую поле интерфейса найденным владельцем

                    panel1.Enabled = true;
                    numPassportOwnertextBox.Enabled = false;
                    MessageBox.Show("Владелец в БД найден!\n");
                }
                else
                {
                    MessageBox.Show("Владелец в БД не найден!\nДобавьте его предварительно в таблицу Владельцы и попробуйте повторить операцию добавления авто");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле паспорта владельца авто!");
            }
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            YearAutodateTimePicker.Format = DateTimePickerFormat.Custom;
            YearAutodateTimePicker.CustomFormat = "yyyy";
            YearAutodateTimePicker.Value = DateTime.Now;
        }
    }
}
