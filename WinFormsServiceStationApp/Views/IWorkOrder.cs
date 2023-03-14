using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IWorkOrder // интерфейс заказ-нарядов
    {
        int wOrderId_Integer { get; set; } // ключ номер заказ наряда

        DateTime wOrderCurrentDate_DateTime { get; set; } // текущая дата

        int orderStateId_Integer { get; set; }  // состояние (статус) работы (в работе или нет например)   

        int wOrderCarId_Integer { get; set; } // автомобиль

        string wOrderCommentOwners_TEXT { get; set; } // неисправность со слов заказчика, либо его пожелания/комментарии к предстоящей работе

        int wOrderOwnerId_Integer { get; set; }   // Владелец (заявитель)

        int wOrderAcceptorId_Integer { get; set; }   // Приемщик (сотрудник)
        
        int wOrderMasterId_Integer { get; set; }   // Мастер-исполнитель (работник)

        List <object> Works_List { get; set; } // список работ к выполнению

        object wOrderViewItems_Object { get; set; } // для получения элементов (для грида) от модели (таблица)   

        byte[] wOrderRowVersion_ByteArray { get; set; } // для параллелизма
    }
}
