using Microsoft.Reporting.WinForms;
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
    public partial class ReportJournalForm : Form, IReport
    {
        int _id_Journal; // уникальный номер записи (ключ) журнала

        public ReportJournalForm(int Id_Journal = -1)
        {
            InitializeComponent();
            _id_Journal = Id_Journal; // получаю номер заказ-наряда, который нужно вывести
        }

        // интерфейсы
        #region IReport (цель: установка источников данных для элементов отчета)
        // IReport (цель: установка источников данных для элементов отчета)
        public object DataJournalWorkOrderList 
        { 
            get => reportViewer1.LocalReport.DataSources["Journal"]; 
            set => reportViewer1.LocalReport.DataSources["Journal"].Value = value; 
        }
        public object DataOwnerList 
        { 
            get => reportViewer1.LocalReport.DataSources["Owner"]; 
            set => reportViewer1.LocalReport.DataSources["Owner"].Value = value;
        }
        public object DataСarList 
        { 
            get => reportViewer1.LocalReport.DataSources["Car"]; 
            set => reportViewer1.LocalReport.DataSources["Car"].Value = value; 
        }
        public object DataAcceptorList 
        { 
            get => reportViewer1.LocalReport.DataSources["WorkerAccepter"];
            set => reportViewer1.LocalReport.DataSources["WorkerAccepter"].Value = value; 
        }
        public object DataMasterList 
        {
            get => reportViewer1.LocalReport.DataSources["WorkerMaster"];
            set => reportViewer1.LocalReport.DataSources["WorkerMaster"].Value = value;
        }
        public object DataWokrsList 
        {
            get => reportViewer1.LocalReport.DataSources["Work"];
            set => reportViewer1.LocalReport.DataSources["Work"].Value = value;
        }
        #endregion

        private void SetupParametersMyReport()
        {              
            reportViewer1.ProcessingMode = ProcessingMode.Local; // Set the processing mode for the ReportViewer to Local            
            reportViewer1.LocalReport.ReportPath = @"..\..\" + "\\Views\\Forms\\Report1.rdlc";
            //  "C:\\Users\\User\\source\\repos\\WinFormsServiceStationApp — копия (2)\\WinFormsServiceStationApp\\Views\\Forms\\Report1.rdlc";
        }

        private void BuildReport()
        {
            try
            {
                SetupParametersMyReport(); // устанавливаю параметры отчета
                Presenters.ReportPresenter reportPresenter = new Presenters.ReportPresenter(this);
                reportPresenter.GetReportData(_id_Journal); // загружаю данные в отчет для соответствующего заказ-наряда
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            BuildReport(); // создаю отчет
            this.reportViewer1.RefreshReport(); // обновляю контрол для просмотра отчета
        }
    }
}
