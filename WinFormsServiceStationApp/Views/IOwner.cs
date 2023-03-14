using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IOwner
    {
        int ownerId_Integer { get; set; } // ключик
        string FullName_Text { get; set; } // имя пользователя
        string Adress_Text { get; set; } // адрес проживания
        string NumPassport_Text { get; set; } // даненые паспорта
        string Phone_Text { get; set; } // контактный телефон

        byte[] ownerRowVersion_ByteArray { get; set; } // токен параллелизма
 
        object OwnerViewItems_Object { get; set; } // для получения элементов для грида от модели    
    }
}
