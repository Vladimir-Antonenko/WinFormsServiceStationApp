using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Models;
using WinFormsServiceStationApp.Views;

namespace WinFormsServiceStationApp.Presenters
{
    public class ReportPresenter
    {
        IReport ReportView;

        public ReportPresenter(IReport view)
        {
            ReportView = view;
        }

        public void GetReportData(int id_Journal)
        {
            var works = Work.lllistWorks(id_Journal);

            var crud = new Crud<WorkOrder>();
            string include = "Owner,Car,Acceptor,Master";
            var recordWorkOrder = crud.GetByFilter(x => x.Id == id_Journal, null, include);

            if (recordWorkOrder != null)
            {
                ReportView.DataJournalWorkOrderList = recordWorkOrder;
                ReportView.DataOwnerList = recordWorkOrder.First().Owner.AsList();
                ReportView.DataСarList = recordWorkOrder.First().Car.AsList();
                ReportView.DataAcceptorList = recordWorkOrder.First().Acceptor.AsList();
                ReportView.DataMasterList = recordWorkOrder.First().Master.AsList();
                ReportView.DataWokrsList = works;
            }
            else
            {
                // ошибка загрузки данных
            }
        }
    }  
}
