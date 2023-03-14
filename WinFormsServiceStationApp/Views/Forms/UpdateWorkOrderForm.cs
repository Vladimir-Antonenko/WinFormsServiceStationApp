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
    public partial class UpdateWorkOrderForm : Form, IWork, IWorker, IDefaultOrderState, IWorkOrder
    {
        public delegate void SetupValueProgressDelegate(int val); // делегат для прогрессбара

        public UpdateWorkOrderForm()
        {
            InitializeComponent();
        }
        public void SetupValueProgress(int val) // для делегата прогрессбара
        {
            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value = progressBar1.Value + val;
        }
        #region IWork
        /// <summary>
        /// 
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
            get => ((ListBox)checkedListBox2).DataSource;
            set => checkedListBox2.UniverseInvoke(() => ((ListBox)checkedListBox2).DataSource = value);
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
        public int wId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wFullName_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wPhone_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wNumPassport_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? wDefaultRoleId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] workerRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        //////
        //IDefaultOrderState
        public int orderStateId_Integer
        {
            get
            {
                if ((int?)comboBox3.SelectedValue != null)
                    return (int)comboBox3.SelectedValue;
                else
                    throw new NotImplementedException();
            }
            set => comboBox3.UniverseInvoke(() => comboBox3.SelectedValue = value);
        }
        public string stateWork_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] orderStateRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public int wOrderId_Integer { get; set; }
        public DateTime wOrderCurrentDate_DateTime
        { 
            get => dateTimePicker1.Value;
            set => dateTimePicker1.UniverseInvoke(() => dateTimePicker1.Value = value);
        }
        public string wOrderCommentOwners_TEXT 
        { 
            get => textBox3.Text;
            set => textBox3.UniverseInvoke(() => textBox3.Text = value);
        }
        public int wOrderCarId_Integer { get; set; }
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
            set => comboBox1.UniverseInvoke(() => comboBox1.SelectedValue = value);
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
            set => comboBox2.UniverseInvoke(() => comboBox2.SelectedValue = value);
        }
        public List<object> Works_List
        {
            get => checkedListBox1.CheckedItems.OfType<object>().ToList();
            set => Works_List = value;
        }
        public object wOrderViewItems_Object { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] wOrderRowVersion_ByteArray { get; set; }
        /// <summary>
        /// ////////////
        /// </summary>
        #endregion

        private void UpdateWorkOrderForm_Load(object sender, EventArgs e)
        {
            panel6.Enabled = false;
            progressBar1.Value = 1;
            progressBar1.Maximum = 4;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";

            dateTimePicker1.Value = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second,
                0);

            ((ListBox)checkedListBox1).DisplayMember = "NameWorks";
            ((ListBox)checkedListBox1).ValueMember = "Id";

            try
            {
                #region должны выполняться последовательно
                //// Эти операции должны выполняться последовательно
                //Presenters.WorkPresenter workPresenter = new Presenters.WorkPresenter(this);
                //workPresenter.GetListWorks(); // загружаю все возможные работы в листбокс (1)
                //workPresenter.GetMyWorks(wOrderId_Integer); // загружаю работы для конкретного заказ-наряда (2)

                //if (checkedListBox1.Items.Count > 0) // тут устанавливаю галочки тем работам из (1), которые содержатся в (2)
                //{
                //    for (int i = 0; i < checkedListBox2.Items.Count; i++)    
                //    for(int j = 0; j < checkedListBox1.Items.Count; j++)           
                //    {
                //       if (checkedListBox2.Items[i].ToString() == checkedListBox1.Items[j].ToString())
                //       {
                //           checkedListBox1.SetItemChecked(j, true);
                //           break;
                //       }           
                //    }  
                //}
                #endregion
                LoadListWorkAsync();
                LoadSettingWorkOrderAsync();
                #region должны выполняться последовательно
                ////////////////////////// должны выполняться последовательно
                /////

                //Presenters.WorkerPresenter workerPresenter = new Presenters.WorkerPresenter(this);
                //workerPresenter.GetWorkerTableWithRoleInfo();
                //Presenters.DefaultOrderStatePresenter statePresenter = new Presenters.DefaultOrderStatePresenter(this);
                //statePresenter.GetDefaultOrderStateTable();

                //Presenters.WorkOrderPresenter workOrderPresenter = new Presenters.WorkOrderPresenter(this);
                //workOrderPresenter.GetById(); // вывести в поля просто

                //// вывожу минимальную информацию об авто
                //var MinimalCarTextBoxInfo = workOrderPresenter.GetMinimalCarInfo_VINandOwner(wOrderCarId_Integer);
                //if (MinimalCarTextBoxInfo != null)
                //{
                //    VIN_TextBox.Text = MinimalCarTextBoxInfo.FirstOrDefault();
                //    nameOwnerCarTextBox.Text = MinimalCarTextBoxInfo.LastOrDefault();
                //}

                //////////////////////////////////////
                #endregion 
                panel6.UniverseInvoke(() => panel6.Enabled = true);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не удалось загрузить списки для выбора! Убедитесь, что таблицы Работники(Сотрудники), Состоятие заказ-наряда и Работы заполнены данными");
                Close();
            }
        }


        private async void LoadListWorkAsync()
        {
            await Task.Run(() =>
            {
                ProgressBar();    // прогресс

                // Эти операции должны выполняться последовательно
                Presenters.WorkPresenter workPresenter = new Presenters.WorkPresenter(this);
                workPresenter.GetListWorks(); // загружаю все возможные работы в листбокс (1)
                workPresenter.GetMyWorks(wOrderId_Integer); // загружаю работы для конкретного заказ-наряда (2)

                if (checkedListBox1.Items.Count > 0) // тут устанавливаю галочки тем работам из (1), которые содержатся в (2)
                {
                    for (int i = 0; i < checkedListBox2.Items.Count; i++)
                        for (int j = 0; j < checkedListBox1.Items.Count; j++)
                        {
                            if (checkedListBox2.Items[i].ToString() == checkedListBox1.Items[j].ToString())
                            {
                                checkedListBox1.UniverseInvoke(() => checkedListBox1.SetItemChecked(j, true));
                                break;
                            }
                        }
                }
            });

            ProgressBar();    // прогресс
        }

        private async void LoadSettingWorkOrderAsync()
        {
            await Task.Run(() =>
            {
                //////////////////////// должны выполняться последовательно
                ///

                Presenters.WorkerPresenter workerPresenter = new Presenters.WorkerPresenter(this);
                workerPresenter.GetWorkerTableWithRoleInfo();
                Presenters.DefaultOrderStatePresenter statePresenter = new Presenters.DefaultOrderStatePresenter(this);
                statePresenter.GetDefaultOrderStateTable();

                Presenters.WorkOrderPresenter workOrderPresenter = new Presenters.WorkOrderPresenter(this);
                workOrderPresenter.GetById(); // вывести в поля просто

                // вывожу минимальную информацию об авто
                var MinimalCarTextBoxInfo = workOrderPresenter.GetMinimalCarInfo_VINandOwner(wOrderCarId_Integer);
                if (MinimalCarTextBoxInfo != null)
                {
                    VIN_TextBox.UniverseInvoke(() => VIN_TextBox.Text = MinimalCarTextBoxInfo.FirstOrDefault());
                    VIN_TextBox.Text = MinimalCarTextBoxInfo.FirstOrDefault();
                    nameOwnerCarTextBox.UniverseInvoke(() => nameOwnerCarTextBox.Text = MinimalCarTextBoxInfo.LastOrDefault());
                }

                ////////////////////////////////////
            });

            ProgressBar();    // прогресс
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

        private void button1_Click(object sender, EventArgs e)
        {
            ShowChoiceCarForm(); // открыть форму выбора авто
        }

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

        private bool CheckFillFields() => VIN_TextBox.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null ? false : true;

        private void button5_Click(object sender, EventArgs e)
        {
            if (CheckFillFields()) // если необдходимые данные в форме введены
            {
                try
                {
                    panel6.Enabled = false; // блокирую выбор элементов
                    Presenters.WorkOrderPresenter workOrder = new Presenters.WorkOrderPresenter(this);
                    workOrder.Update_WorkOrder_Elem();
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
        ///////////
        ////////
        ///

    }
}
