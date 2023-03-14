using System;
using System.Collections;
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
    public partial class AddWorkOrderForm : Form, IWork, IWorker, IDefaultOrderState, IWorkOrder
    {
        // интерфейсы
        #region IWork
        /// <summary>
        /// ///////////
        /// </summary>
        // IWork
        public int workId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string nameWorks_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public double price_Double 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object WorkList_Object 
        {
            get => ((ListBox)checkedListBox1).DataSource;
            set => checkedListBox1.UniverseInvoke(() => ((ListBox)checkedListBox1).DataSource = value);
        }
        public object WorkListLISTBOX_Object 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public byte[] workRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        #endregion
        #region IWorker
        /// <summary>
        /// 
        /// </summary>
        // IWorker
        public int wId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string wFullName_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string wPhone_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string wNumPassport_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public int? wDefaultRoleId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public byte[] workerRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object WorkerViewItems
        {
            get => comboBox2.DataSource;
            set => comboBox2.UniverseInvoke(() => comboBox2.DataSource = value);
        }
        
        public object wOrderViewAcceptorsItems_Object
        {
            get => comboBox1.DataSource;
            set => comboBox1.UniverseInvoke(() => comboBox1.DataSource = value);
        }
        #endregion
        #region IDefaultOrderState
        /// <summary>
        /// 
        /// </summary>
        // IDefaultOrderState
        public int orderStateId_Integer
        {
            get
            {
                if ((int?)comboBox3.SelectedValue != null)
                    return (int)comboBox3.SelectedValue;
                else
                    throw new NotImplementedException();
            }
            set => comboBox3.SelectedValue = value;
        }
        public string stateWork_Text 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public byte[] orderStateRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public object orderStateViewItems_Object
        {
            get => comboBox3.DataSource;
            set => comboBox3.UniverseInvoke(() => comboBox3.DataSource = value);
        }
        #endregion
        #region IWorkOrder
        /// <summary>
        /// 
        /// </summary>
        // IWorkOrder
        public int wOrderId_Integer 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public DateTime wOrderCurrentDate_DateTime 
        { 
            get => dateTimePicker1.Value;
            set => dateTimePicker1.Value = value; 
        }
        public int wOrderCarId_Integer { get; set; }
        public string wOrderCommentOwners_TEXT 
        { 
            get => textBox3.Text; 
            set => textBox3.Text = value;        
        }
        public int wOrderOwnerId_Integer { get; set; }
        public int wOrderAcceptorId_Integer 
        {
            get
            {
                if ((int?)comboBox1.SelectedValue != null)
                    return (int)comboBox1.SelectedValue;
                else
                    throw new NotImplementedException();
            }
            set => comboBox1.SelectedValue = value; 
        }
        public int wOrderMasterId_Integer
        {
            get
            {
                if ((int?)comboBox2.SelectedValue != null)
                    return (int)comboBox2.SelectedValue;
                else
                    throw new NotImplementedException();
            }
            set => comboBox2.SelectedValue = value;
        }
        public List<object> Works_List 
        { 
            get => checkedListBox1.CheckedItems.OfType<object>().ToList(); 
            set => Works_List = value;
        }
        public object wOrderViewItems_Object 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public byte[] wOrderRowVersion_ByteArray 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        #endregion

        public delegate void SetupValueProgressDelegate(int val); // делегат для прогрессбара

        public AddWorkOrderForm()
        {
            InitializeComponent();
        }

        private bool CheckFillFields() => VIN_TextBox.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null ? false : true;

        public void SetupValueProgress(int val) // для делегата прогрессбара
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value = progressBar1.Value + val;
        }

        private void ProgressBar(int val = 1) // прогресс
        {
            if (InvokeRequired)
                Invoke(new SetupValueProgressDelegate(SetupValueProgress), new object[] { val });
            else
                progressBar1.Value = progressBar1.Value + val;
        }

        private void AddWorkOrderForm_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            progressBar1.Maximum = 4;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            dateTimePicker1.Value = new System.DateTime(
                System.DateTime.Now.Year,
                System.DateTime.Now.Month,
                System.DateTime.Now.Day,
                System.DateTime.Now.Hour,
                System.DateTime.Now.Minute,
                System.DateTime.Now.Second,
                0);

            ((ListBox)checkedListBox1).DisplayMember = "NameWorks";
            ((ListBox)checkedListBox1).ValueMember = "Id";

            try
            {
                // заполняю комбо и лист боксы
                LoadListWorkAsync();
                LoadListWorkerAsync();
                LoadListStateWorkAsync();

            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка! Не удалось загрузить списки для выбора! Убедитесь, что таблицы Работники(Сотрудники), Состоятие заказ-наряда и Работы заполнены данными");
                Close();
            }
        }

        private async void LoadListWorkAsync()
        {
            Presenters.WorkPresenter workPresenter = new Presenters.WorkPresenter(this);
            await Task.Run(() => { workPresenter.GetListWorks(); });
            ProgressBar();    // прогресс
        }

        private async void LoadListWorkerAsync()
        {
            Presenters.WorkerPresenter workerPresenter = new Presenters.WorkerPresenter(this);
            await Task.Run(() => { workerPresenter.GetWorkerTableWithRoleInfo(); });
            ProgressBar();    // прогресс
        }

        private async void LoadListStateWorkAsync()
        {
            Presenters.DefaultOrderStatePresenter statePresenter = new Presenters.DefaultOrderStatePresenter(this);
            await Task.Run(() => { statePresenter.GetDefaultOrderStateTable(); });
            ProgressBar();    // прогресс
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(CheckFillFields()) // если необдходимые данные в форме введены
            {
                try
                {
                    panel6.Enabled = false; // блокирую выбор элементов
                    Presenters.WorkOrderPresenter workOrder = new Presenters.WorkOrderPresenter(this);
                    workOrder.Add_WorkOrder_Elem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) => ShowChoiceCarForm(); // открыть форму выбора авто
        
        private void ShowChoiceCarForm() // открыть форму выбора авто
        {
            using (ChoiceCarForm choiceCarForm = new ChoiceCarForm())
            {
                choiceCarForm.Owner = this; // делаю форму родительской
                choiceCarForm.ShowDialog(this); // Окно перехватывает фокус
                                              
                // передаю данные в родительскую форму
                if (choiceCarForm.sucsess == true) // если успешно выбрали авто то сохраняем себе основные интересующие нас параметры
                {
                    VIN_TextBox.Text = choiceCarForm.exctractVIN;

                    nameOwnerCarTextBox.Text = choiceCarForm.exctractNameOwner;
                    wOrderCarId_Integer = choiceCarForm.exctractCarId;

                    if (choiceCarForm.exctractFK_OwnerId != null)
                        wOrderOwnerId_Integer = (int)choiceCarForm.exctractFK_OwnerId;
                    else
                    {
                        MessageBox.Show("Авто не выбрано или выбрано авто без водителя! !");
                    }
                    panel12.Visible = true;
                }
            }
        }
    }
}
