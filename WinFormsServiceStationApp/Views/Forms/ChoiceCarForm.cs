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
    public partial class ChoiceCarForm : Form, ICar
    {
        int curretrRowIndexForShow = -1;
        int curMouseOverRow = -1;

        int MAX_PROGRESS_BAR = 4;

        public delegate void SetupValueProgressDelegate(int val); // делегат для прогрессбара

        // для возврата в родительскую форму
        public int exctractCarId = -1;
        public int? exctractFK_OwnerId = null;
        public string exctractVIN = "";
        public string exctractNameOwner = "";
        public bool sucsess = false;

        // интерйефсы
        #region ICar
        /// <summary>
        /// ///////
        /// </summary>
        // ICar
        public int CarId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string VIN_Text 
        { 
            get => VINSearchTextBox.Text; 
            set => VINSearchTextBox.Text = value; 
        }
        public string numReg_Text 
        { 
            get => regNumSearchTextBox.Text; 
            set => regNumSearchTextBox.Text = value;
        }
        public string nameBrand_Text 
        { 
            get => brandSearchTextBox.Text; 
            set => brandSearchTextBox.Text = value; 
        }
        public string nameModel_Text 
        { 
            get => modelSearchTextBox.Text; 
            set => modelSearchTextBox.Text = value; 
        }
        public int? ForeignCarOwnerId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public DateTime dateRelease_DateTime 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public byte[] carRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object CarViewItems_Object
        {
            get => dataGridView6.DataSource;
            set => dataGridView6.UniverseInvoke(() => dataGridView6.DataSource = value);
        }
        #endregion

        public ChoiceCarForm()
        {
            InitializeComponent();
        }

        public void SetupValueProgress(int val) // для делегата прогрессбара
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value = progressBar1.Value + val;
        }

        private void ChoiceCarForm_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            progressBar1.Maximum = MAX_PROGRESS_BAR;

            dataGridView6.DoubleBuffered(true);

            LoadTableAsync();
        }

        private void dataGridView6_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView6.RowPrePait_UserOverride(e);
        private void dataGridView6_MouseDown(object sender, MouseEventArgs e) => dataGridView6.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShow, ref curMouseOverRow);
        private void dataGridView6_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShow = e.RowIndex;
            dataGridView6.Rows[curretrRowIndexForShow].Selected = true;
        }

        private async void LoadTableAsync()
        {
            Presenters.CarPresenter carPresenter = new Presenters.CarPresenter(this);
            await Task.Run(() => { carPresenter.GetCarTableOnlyWithOwners(); });
            ProgressBar(3);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (VINSearchTextBox.Text.Trim() != "" // если хотя бы одно поле для поиска вбито
              || regNumSearchTextBox.Text.Trim() != ""
                  || brandSearchTextBox.Text.Trim() != "" 
                    || modelSearchTextBox.Text.Trim() != "")
            {
                progressBar1.Value = 1;
                Presenters.CarPresenter carPresenter = new Presenters.CarPresenter(this);
                carPresenter.SearchByManyPatametersWithOwnerONLY(); // поиск по параметрам и доп условием по дефолту только с влладельцами искать
                progressBar1.Value = MAX_PROGRESS_BAR;
            }
            else
            {
                dataGridView6.DataSource = null;
                MessageBox.Show("Введите параметры для поиска и повторите снова");
            }
        }

        private void выбратьАвтомобильИДобавитьЕгоВЗаказнарядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExtractParametersByRow() == true) // sucsess успешно
                this.Close();
        }

        private bool ExtractParametersByRow()
        {
            sucsess = false;

            // нужно извлечь Id, OwnerId, Vin, OwnerName для предыдущей формы
            if (curretrRowIndexForShow >= 0 && dataGridView6.DataSource != null)
            {
                var Row = dataGridView6.Rows[curretrRowIndexForShow];
                try
                {
                    // пробую извлечь параметры
                    exctractCarId = (int)Row.Cells[7].Value;
                    exctractFK_OwnerId = (int?)Row.Cells[5].Value;
                    exctractVIN = (string)Row.Cells[0].Value;
                    exctractNameOwner = Row.Cells[6].Value != null ? Row.Cells[6].Value.ToString() : "";

                    sucsess = true;   // параметры успешно извлечены
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана! Выберите и повторите снова!");
            }

            return sucsess;
        }

        private void ProgressBar(int val = 1)
        {
            // прогресс
            if (InvokeRequired)
            {
                Invoke(new SetupValueProgressDelegate(SetupValueProgress), new object[] { val });
            }
            else
                progressBar1.Value = progressBar1.Value + val;
        }
    }
}
