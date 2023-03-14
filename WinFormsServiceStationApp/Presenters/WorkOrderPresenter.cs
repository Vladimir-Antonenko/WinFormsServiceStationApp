using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Views;
using WinFormsServiceStationApp.Models;
using System.Collections;

namespace WinFormsServiceStationApp.Presenters
{
    public class WorkOrderPresenter
    {
        IWorkOrder WorkOrderView;

        public WorkOrderPresenter(IWorkOrder view)
        {
            WorkOrderView = view;
        }

        public void Add_WorkOrder_Elem()
        {
            WorkOrder wOrder = new WorkOrder();
            wOrder.CarId = WorkOrderView.wOrderCarId_Integer;
            wOrder.OwnerId = WorkOrderView.wOrderOwnerId_Integer;
            wOrder.CommentOwners = WorkOrderView.wOrderCommentOwners_TEXT.Trim();
            wOrder.AcceptorId = WorkOrderView.wOrderAcceptorId_Integer;
            wOrder.MasterId = WorkOrderView.wOrderMasterId_Integer;

            if (WorkOrderView.Works_List != null)
            {
                foreach (var x in WorkOrderView.Works_List.OfType<Work>().ToList())
                {
                    wOrder.WorkOrderWorks.Add(new WorkOrderWork
                    {
                        WorkId = x.Id,
                        WorkOrderId = wOrder.Id
                    });
                }
            }

            wOrder.OrderStateId = WorkOrderView.orderStateId_Integer;
            wOrder.CurrentDate = WorkOrderView.wOrderCurrentDate_DateTime;

            var crudd = new Crud<WorkOrder>(); // репозиторий 
            crudd.Create(wOrder); // задаем добавляемую entity и поле по которому проверим есть уже элемент или нет в таблице
        }

        public void Update_WorkOrder_Elem()
        {
            WorkOrder wOrder = new WorkOrder();

            wOrder.Id = WorkOrderView.wOrderId_Integer;
            wOrder.RowVersion = WorkOrderView.wOrderRowVersion_ByteArray;

            wOrder.CarId = WorkOrderView.wOrderCarId_Integer;
            wOrder.OwnerId = WorkOrderView.wOrderOwnerId_Integer;
            wOrder.CommentOwners = WorkOrderView.wOrderCommentOwners_TEXT.Trim();
            wOrder.AcceptorId = WorkOrderView.wOrderAcceptorId_Integer;
            wOrder.MasterId = WorkOrderView.wOrderMasterId_Integer;

            List<WorkOrderWork> newWorks = new List<WorkOrderWork>();

            if (WorkOrderView.Works_List != null)
            {
                foreach (var x in WorkOrderView.Works_List.OfType<Work>().ToList())
                {
                    newWorks.Add(new WorkOrderWork
                    {
                        WorkId = x.Id,
                        WorkOrderId = wOrder.Id
                    });
                }
            }

            wOrder.OrderStateId = WorkOrderView.orderStateId_Integer;
            wOrder.CurrentDate = WorkOrderView.wOrderCurrentDate_DateTime;

            wOrder.UpdateMyWorkOrderRecord(newWorks); // обновляю в рамках одной транзакции заказ-наряд и связанные с ним работы
        }

        public void GetWorkOrdersTable()
        {
            var crud = new Crud<WorkOrder>();
            List<WorkOrder> DataJournalOrderWork = crud.GetAll(); // получаю данные журнала

            WorkOrderView.wOrderViewItems_Object = DataJournalOrderWork;
        }

        public void GetById()
        {
            var crud = new Crud<WorkOrder>();
            var elemList = crud.FindAndReturnElemByKey_ToList(WorkOrderView.wOrderId_Integer);
            if(elemList != null)
            {
                var elem = elemList.First();
                // тут всех присвоить WorkOrderView
                WorkOrderView.wOrderAcceptorId_Integer = elem.AcceptorId;
                WorkOrderView.wOrderCarId_Integer = elem.CarId;
                WorkOrderView.wOrderOwnerId_Integer = elem.OwnerId;
                WorkOrderView.wOrderCommentOwners_TEXT = elem.CommentOwners;
                WorkOrderView.wOrderMasterId_Integer = elem.MasterId;
                WorkOrderView.orderStateId_Integer = elem.OrderStateId;
                WorkOrderView.wOrderCurrentDate_DateTime = elem.CurrentDate;
            }
        }

        public List<string> GetMinimalCarInfo_VINandOwner(int id)
        {
            return Car.GetVIN_And_Owner_byKey(id);
        }

        public void DeleteThisRecord(int id)
        {
            var crud = new Crud<WorkOrder>();
            crud.Delete(id);
        }
    }
}
