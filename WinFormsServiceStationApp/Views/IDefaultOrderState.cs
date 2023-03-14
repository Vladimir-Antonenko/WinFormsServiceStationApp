using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IDefaultOrderState
    {
        int orderStateId_Integer { get; set; } // ключ номер для состояния заказа
        string stateWork_Text { get; set; } // состояние (статус) работы (в работе или нет например)
        byte[] orderStateRowVersion_ByteArray { get; set; } // токен параллелизма

        object orderStateViewItems_Object { get; set; } // для получения элементов для грида от модели    
    }
}
