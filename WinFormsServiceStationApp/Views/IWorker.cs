using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IWorker
    {
        int wId_Integer { get; set; } // ключ номер работника
        string wFullName_Text { get; set; } // имя рабочего
        string wPhone_Text { get; set; } // контактный телефон
        string wNumPassport_Text { get; set; } // данные паспорта

        int? wDefaultRoleId_Integer { get; set; }  // должность из таблицы DefaultRole

        byte[] workerRowVersion_ByteArray { get; set; } // токен параллелизма

        object WorkerViewItems { get; set; } // для получения элементов для грида от модели
                                             
        object wOrderViewAcceptorsItems_Object { get; set; } // для получения элементов для комбобокса от модели (таблица) 
    }
}
