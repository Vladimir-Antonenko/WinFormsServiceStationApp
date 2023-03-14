using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsServiceStationApp.Views.Forms;
using WinFormsServiceStationApp.Views;


namespace WinFormsServiceStationApp
{
    public partial class MainForm : Form, ICar, IOwner, IWorker, IWork, IWorkOrder
    {
        // параметры элементов формы
        bool ContextClickTabPageIndexChange = false;

        #region параметры для строки и мыши в гридах
        // параметры для строки и мыши в гридах
        int curretrRowIndexForShowCAR_TABLE = -1; // индекс текущей строки для грид1
        int curMouseOverRowCAR_TABLE = -1; // куда ткнули мышкой

        int curretrRowIndexForShowOWNER_TABLE = -1;
        int curMouseOverRowOWNER_TABLE = -1;

        int curretrRowIndexForShow_WORK_TABLE = -1;
        int curMouseOverRow_WORK_TABLE = -1;

        int curretrRowIndexForShow_WORKER_TABLE = -1;
        int curMouseOverRow_WORKER_TABLE = -1;

        int curretrRowIndexForShow_WORkORDER_TABLE = -1;
        int curMouseOverRow_WORkORDER_TABLE = -1;
        #endregion

        // интерфейсы
        #region ICar
        /// <summary>
        /// /////////////////
        /// </summary>
        // ICar
        public int CarId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string VIN_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string numReg_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nameBrand_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nameModel_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? ForeignCarOwnerId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime dateRelease_DateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] carRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object CarViewItems_Object
        { 
            get => dataGridView1.DataSource; 
            set => dataGridView1.UniverseInvoke(() => dataGridView1.DataSource = value); 
        }
        #endregion
        #region IOwner
        /// <summary>
        /// //////////////
        /// </summary>
        // IOwner
        public int ownerId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FullName_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Adress_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NumPassport_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] ownerRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object OwnerViewItems_Object
        { 
            get => dataGridView2.DataSource; 
            set => dataGridView2.UniverseInvoke(() => dataGridView2.DataSource = value);
        }
        #endregion
        #region IWork
        /// <summary>
        /// /////////////
        /// </summary>
        //IWork
        public int workId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nameWorks_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double price_Double { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object WorkList_Object 
        { 
            get => dataGridView3.DataSource; 
            set => dataGridView3.UniverseInvoke(() => dataGridView3.DataSource = value);
        }
        public object WorkListLISTBOX_Object 
        { 
            get => checkedListBox1.CheckedItems.OfType<object>().ToList(); 
            set => checkedListBox1.UniverseInvoke(() => ((ListBox)checkedListBox1).DataSource = value);
        }
        public byte[] workRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion
        #region Iworker
        /// <summary>
        /// /////////////////
        /// </summary>
        // Iworker 
        public int wId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wFullName_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wPhone_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wNumPassport_Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? wDefaultRoleId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] workerRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object WorkerViewItems 
        { 
            get => dataGridView4.DataSource; 
            set => dataGridView4.UniverseInvoke(() => dataGridView4.DataSource = value);
        }

        public object wOrderViewAcceptorsItems_Object { get; set; }
        #endregion
        #region IWorkOrder
        /// <summary>
        /// 
        /// </summary>
        //IWorkOrder
        public int wOrderId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime wOrderCurrentDate_DateTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int orderStateId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int wOrderCarId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string wOrderCommentOwners_TEXT { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int wOrderOwnerId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int wOrderAcceptorId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int wOrderMasterId_Integer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<object> Works_List { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object wOrderViewItems_Object 
        { 
            get => dataGridView5.DataSource; 
            set => dataGridView5.UniverseInvoke(() => dataGridView5.DataSource = value); 
        }
        public byte[] wOrderRowVersion_ByteArray { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            GridSetupForPages();
            ((ListBox)checkedListBox1).DisplayMember = "NameWorks"; // то что будет показано
            ((ListBox)checkedListBox1).ValueMember = "Id"; // то что получу как значение
        }

        private void GridSetupForPages()
        {
            dataGridView1.DoubleBuffered(true);
            dataGridView2.DoubleBuffered(true);
            dataGridView3.DoubleBuffered(true);
            dataGridView4.DoubleBuffered(true);
            dataGridView5.DoubleBuffered(true);
        }

        private void DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView1.RowPrePait_UserOverride(e);
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e) => dataGridView1.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShowCAR_TABLE, ref curMouseOverRowCAR_TABLE);
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShowCAR_TABLE = e.RowIndex;
            dataGridView1.Rows[curretrRowIndexForShowCAR_TABLE].Selected = true;
        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView2.RowPrePait_UserOverride(e);
        private void dataGridView2_MouseDown(object sender, MouseEventArgs e) => dataGridView2.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShowOWNER_TABLE, ref curMouseOverRowOWNER_TABLE);
        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShowOWNER_TABLE = e.RowIndex;
            dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Selected = true;
        }

        private void dataGridView3_MouseDown(object sender, MouseEventArgs e) => dataGridView3.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShow_WORK_TABLE, ref curMouseOverRow_WORK_TABLE);
        private void dataGridView3_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView3.RowPrePait_UserOverride(e);
        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShow_WORK_TABLE = e.RowIndex;
            dataGridView3.Rows[curretrRowIndexForShow_WORK_TABLE].Selected = true;
        }

        private void dataGridView4_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView4.RowPrePait_UserOverride(e);
        private void dataGridView4_MouseDown(object sender, MouseEventArgs e) => dataGridView4.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShow_WORKER_TABLE, ref curMouseOverRow_WORKER_TABLE);      
        private void dataGridView4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShow_WORKER_TABLE = e.RowIndex;
            dataGridView4.Rows[curretrRowIndexForShow_WORKER_TABLE].Selected = true;
        }

        private void dataGridView5_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) => dataGridView5.RowPrePait_UserOverride(e);
        private void dataGridView5_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView5.MouseDownSelectRow_UserOverride(e, ref curretrRowIndexForShow_WORkORDER_TABLE, ref curMouseOverRow_WORkORDER_TABLE);
            ShowListWorksAtCheckListBox();
        }
        private void dataGridView5_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            curretrRowIndexForShow_WORkORDER_TABLE = e.RowIndex;
            dataGridView5.Rows[curretrRowIndexForShow_WORkORDER_TABLE].Selected = true;

            ShowListWorksAtCheckListBox(); // отображаю список работ для текущей строки
        }

        private void ShowListWorksAtCheckListBox() // отображаю список работ для текущей строки
        {
            if (dataGridView5.DataSource != null && curretrRowIndexForShow_WORkORDER_TABLE >= 0 && dataGridView5.Columns.Count >= 13)
            {
                int index = -1;
                index = (int)dataGridView5.Rows[curretrRowIndexForShow_WORkORDER_TABLE].Cells[13].Value;

                Presenters.WorkPresenter workPresenter = new Presenters.WorkPresenter(this);
                workPresenter.GetMyWorks(index);
            }
        }

        private void ShowStateOrderForm() // открыть форму должностей
        {
            using (DefaultOrderStateForm orderStateForm = new DefaultOrderStateForm())
            {
                orderStateForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void ShowRoleForm() // открыть форму должностей
        {
            using (DefaultRoleForm roleForm = new DefaultRoleForm())
            {
                roleForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void AddNewCarForm()  // открыть форму добавления авто
        {
            using (AddCarForm newCarForm = new AddCarForm())
            {
                newCarForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void AddNewOwnerForm()  // открыть форму добавления владельца
        {
            using (AddOwnerForm newOwnerForm = new AddOwnerForm())
            {
                newOwnerForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void AddNewWorkForm()  // открыть форму добавления работы
        {
            using (AddWorkForm newworkForm = new AddWorkForm())
            {
                newworkForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void AddNewWorkerForm()  // открыть форму добавления работника (сотрудника)
        {
            using (AddWorkerForm newworkerForm = new AddWorkerForm())
            {
                newworkerForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void AddNew_WorkOrder_Form()  // открыть форму для создания нового заказ-наряда
        {
            using (AddWorkOrderForm newWorkOrderForm = new AddWorkOrderForm())
            {
                newWorkOrderForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void UpdateElemCarForm() // форма обновления авто
        {
            using (UpdateCarForm updateCarForm = new UpdateCarForm())
            {
                var Row = dataGridView1.Rows[curretrRowIndexForShowCAR_TABLE];
                updateCarForm.VIN_Text = Row.Cells[0].Value != null ? (string)Row.Cells[0].Value : "";
                updateCarForm.numReg_Text = Row.Cells[1].Value != null ? (string)Row.Cells[1].Value : "";
                updateCarForm.nameBrand_Text = Row.Cells[2].Value != null ? (string)Row.Cells[2].Value : "";
                updateCarForm.nameModel_Text = Row.Cells[3].Value != null ? (string)Row.Cells[3].Value : "";
                updateCarForm.dateRelease_DateTime = Row.Cells[4].Value != null ? (DateTime)Row.Cells[4].Value : DateTime.MinValue;
                updateCarForm.ForeignCarOwnerId_Integer = Row.Cells[5].Value != null ? (int?)Row.Cells[5].Value : null;
                updateCarForm.fullNamecurrentCARowner = Row.Cells[6].Value != null ? Row.Cells[6].Value.ToString() : "";
                updateCarForm.CarId_Integer = Row.Cells[7].Value != null ? (int)Row.Cells[7].Value : -1;
                updateCarForm.carRowVersion_ByteArray = Row.Cells[8].Value != null ? (byte[])Row.Cells[8].Value : null;

                updateCarForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void UpdateElemOwnerForm() // форма обновления владельца
        {
            using (UpdateOwnerForm updateOwnerForm = new UpdateOwnerForm())
            {
                updateOwnerForm.FullName_Text = (string)dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[0].Value;
                updateOwnerForm.Adress_Text = (string)dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[1].Value;
                updateOwnerForm.NumPassport_Text = (string)dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[2].Value;
                updateOwnerForm.Phone_Text = (string)dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[3].Value;
                updateOwnerForm.ownerId_Integer = (int)dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[5].Value;
                updateOwnerForm.ownerRowVersion_ByteArray = (byte[])dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[6].Value;

                updateOwnerForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void UpdateElemWorkOrderForm()
        {
            using (UpdateWorkOrderForm updateJournalForm = new UpdateWorkOrderForm())
            {
                // передаю только самое основное: ключ и токен параллелизма
                updateJournalForm.wOrderRowVersion_ByteArray = (byte[])dataGridView5.Rows[curMouseOverRow_WORkORDER_TABLE].Cells[14].Value;
                updateJournalForm.wOrderId_Integer = (int)dataGridView5.Rows[curMouseOverRow_WORkORDER_TABLE].Cells[13].Value;

                updateJournalForm.ShowDialog(this); // Окно перехватывает фокус
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContextClickTabPageIndexChange == true) // если сменили вкладку переходом из контекстного меню 
            {
                ContextClickTabPageIndexChange = false;
            }
            else
            {
                // возвращаю видимость кнопкам
                перейтиКАвтомобилямДанногоВладельцаToolStripMenuItem1.Visible = true;
                перейтиКВладельцуДанногоАвтоToolStripMenuItem.Visible = true;

                UpdateGridAsync(); // обновляю грид
            }
        }

        private async void UpdateGridAsync() // обновляю данные в выбранной вкладке
        {
            try
            {
                int SelectedIndex = tabControl1.SelectedIndex;

                await Task.Run(() =>
                {

                    switch (SelectedIndex)
                    {
                        case 0:
                            Presenters.CarPresenter carPresenter = new Presenters.CarPresenter(this);
                            carPresenter.GetCarTable();
                        //    перейтиКВладельцуДанногоАвтоToolStripMenuItem.Visible = true;
                            break;
                        case 1:
                            Presenters.OwnerPresenter ownerPresenter = new Presenters.OwnerPresenter(this);
                            ownerPresenter.GetOwnerTableWithCarsInfo();

                        //    перейтиКАвтомобилямДанногоВладельцаToolStripMenuItem.Visible = true;
                            break;
                        case 2:
                            Presenters.WorkPresenter workPresenter = new Presenters.WorkPresenter(this);
                            workPresenter.GetListWorks();
                            break;
                        case 3:
                            Presenters.WorkerPresenter workerPresenter = new Presenters.WorkerPresenter(this);
                            workerPresenter.GetWorkerTableWithRoleInfo();
                            break;
                        case 4:
                            Presenters.WorkOrderPresenter workOrderPresenter = new Presenters.WorkOrderPresenter(this);
                            workOrderPresenter.GetWorkOrdersTable();
                            break;
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Не удалось загрузить выбранную таблицу! \n" + ex.Message.ToString());
            }
        }

        private void добавитьНовуюЗаписьВТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    AddNewCarForm();  // открыть форму создания авто
                    break;
                case 1:
                    AddNewOwnerForm();  // открыть форму добавления владельца
                    break;
                case 2:
                    AddNewWorkForm(); // открыть форму для добавления работ
                    break;
                case 3:
                    AddNewWorkerForm(); // открыть форму для добавленияработника
                    break;
                case 4:
                    AddNew_WorkOrder_Form(); // открыть форму создания заказ-наряда
                    break;
            }

            UpdateGridAsync(); // обновляю грид после операции
        }

        private void редактироватьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex) // при смене вкладки табконтрола
            {
                case 0:
                    if(curretrRowIndexForShowCAR_TABLE >=0 && dataGridView1.DataSource != null)
                        UpdateElemCarForm();  // редактировать авто
                    break;
                case 1:
                    if(curretrRowIndexForShowOWNER_TABLE >= 0 && dataGridView2.DataSource != null)
                        UpdateElemOwnerForm();  // редактировать владельца
                    break;
                case 2:
                    ;
                    break;
                case 3:
                    ;
                    break;
                case 4:
                    if(curretrRowIndexForShow_WORkORDER_TABLE>= 0 && dataGridView5.DataSource != null)
                        UpdateElemWorkOrderForm();  // редактировать заказ-наряд;
                    break;
            }

            UpdateGridAsync(); // обновляю грид после операции
        }
        private void перейтиКАвтомобилямДанногоВладельцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource != null && curretrRowIndexForShowOWNER_TABLE >= 0) // строка будет выбрана только если грид не пуст и выбрана строка
            {
                ContextClickTabPageIndexChange = true;
                tabControl1.SelectedIndex = 0; // перехожу к вкладке авто
                dataGridView1.DataSource = dataGridView2.Rows[curretrRowIndexForShowOWNER_TABLE].Cells[4].Value;

                перейтиКВладельцуДанногоАвтоToolStripMenuItem.Visible = false;
            }
        }

        private void перейтиКВладельцуДанногоАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && curretrRowIndexForShowCAR_TABLE >= 0) // строка будет выбрана только если грид не пуст и выбрана строка
            {
                ContextClickTabPageIndexChange = true;
                tabControl1.SelectedIndex = 1; // перехожу к вкладке владельцы

                int? findKeyOwner = (int?)dataGridView1.Rows[curretrRowIndexForShowCAR_TABLE].Cells[5].Value; // беру ключ владельца
               
                // и отправляюсь его искать в таблице владельцы
                Presenters.OwnerPresenter ownerTablePresenter = new Presenters.OwnerPresenter(this);
                ownerTablePresenter.FindAndGetOneElemForGrid(findKeyOwner); 

                перейтиКАвтомобилямДанногоВладельцаToolStripMenuItem1.Visible = false;
            }
        }

        private void создатьОтчетReportViewerДляДанногоЗаказнарядаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView5.DataSource != null && curretrRowIndexForShow_WORkORDER_TABLE >= 0 && dataGridView5.Columns.Count>13) // строка будет выбрана только если грид не пуст и выбрана строка
            {
                int keyPrint_WorkOrder = (int)dataGridView5.Rows[curretrRowIndexForShow_WORkORDER_TABLE].Cells[13].Value;

                using (ReportJournalForm f = new ReportJournalForm(keyPrint_WorkOrder))
                {
                    f.ShowDialog();
                }
            }
        }

        private void удалитьЗаказнарядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView5.DataSource != null && curretrRowIndexForShow_WORkORDER_TABLE >=0)
            {
                int key = (int)dataGridView5.Rows[curretrRowIndexForShow_WORkORDER_TABLE].Cells[13].Value;

                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить выбранный заказ-наряд?", "Удаление выбранной записи", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        {
                            // удаляю
                            Presenters.WorkOrderPresenter workOrderPresenter = new Presenters.WorkOrderPresenter(this);
                            workOrderPresenter.DeleteThisRecord(key);

                            UpdateGridAsync(); // обновляю грид после операции

                            //int countObj = dataGridView5.Rows.Count;
                            //if (countObj < 0)
                            //{
                            //    dataGridView5.DataSource = null;
                            //    curretrRowIndexForShow_WORkORDER_TABLE = -1;
                            //}
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e) => ShowStateOrderForm(); // открыть форму должностей     
        private void button8_Click(object sender, EventArgs e) => ShowRoleForm(); // открыть форму должностей     
    }
}
