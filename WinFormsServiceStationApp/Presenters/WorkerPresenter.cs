using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Models;
using WinFormsServiceStationApp.Views;

namespace WinFormsServiceStationApp.Presenters
{
    public class WorkerPresenter
    {
        IWorker WorkerView;

        public WorkerPresenter(IWorker view)
        {
            WorkerView = view;
        }

        public void AddWorkerElem()
        {
            Worker worker = new Worker();
            worker.NumPassport = WorkerView.wNumPassport_Text.Trim();
            worker.Phone = WorkerView.wPhone_Text.Trim();
            worker.FullName = WorkerView.wFullName_Text.Trim();
            worker.DefaultRoleId = WorkerView.wDefaultRoleId_Integer;

            var crud = new Crud<Worker>(); // репозиторий 
            crud.Create(worker, x => x.NumPassport == worker.NumPassport); // задаем добавляемую entity и поле по которому проверим есть уже элемент или нет в таблице         
        }

        public void GetWorkerTableWithRoleInfo() // получить таблицу рабочие
        {
            var crud = new Crud<Worker>();
            WorkerView.WorkerViewItems = crud.GetWithBindData();
            WorkerView.wOrderViewAcceptorsItems_Object = crud.GetWithBindData();
        }
    }
}
