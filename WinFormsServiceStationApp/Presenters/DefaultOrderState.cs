using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Views;
using WinFormsServiceStationApp.Models;

namespace WinFormsServiceStationApp.Presenters
{
    public class DefaultOrderStatePresenter
    {
        IDefaultOrderState DefaultOrderState_View;

        public DefaultOrderStatePresenter(IDefaultOrderState view)
        {
            DefaultOrderState_View = view;
        }

        public void AddStateElem()
        {
            DefaultOrderState orderState = new DefaultOrderState();
            orderState.StateWork = DefaultOrderState_View.stateWork_Text.Trim();
           
            var crud = new Crud<DefaultOrderState>(); // репозиторий 
            crud.Create(orderState); // задаем добавляемую entity         
        }

        public void GetDefaultOrderStateTable()
        {
            var crud = new Crud<DefaultOrderState>();       
            DefaultOrderState_View.orderStateViewItems_Object = crud.GetWithBindData();
        }

        public void UpdateState()
        {
            DefaultOrderState orderState = new DefaultOrderState();
            orderState.Id = DefaultOrderState_View.orderStateId_Integer;
            orderState.StateWork = DefaultOrderState_View.stateWork_Text.Trim();
            orderState.RowVersion = DefaultOrderState_View.orderStateRowVersion_ByteArray;

            var crud = new Crud<DefaultOrderState>(); // репозиторий 
            crud.Update(orderState); // задаем обновляемую entity
        }

        public void RemoveState()
        {
            DefaultOrderState orderState = new DefaultOrderState();
            orderState.Id = DefaultOrderState_View.orderStateId_Integer;
            orderState.StateWork = DefaultOrderState_View.stateWork_Text.Trim();
            orderState.RowVersion = DefaultOrderState_View.orderStateRowVersion_ByteArray;

            var crud = new Crud<DefaultOrderState>(); // репозиторий 
            crud.Delete(orderState); // задаем удаляемую entity
        }
    }
}