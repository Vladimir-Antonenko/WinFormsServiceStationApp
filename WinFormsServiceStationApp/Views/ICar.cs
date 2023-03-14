using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface ICar
    {
        int CarId_Integer { get; set; } // ключ номер автомобиля
        string VIN_Text { get; set; } // вин или номер кузова
        string numReg_Text { get; set; } //госномер 
        string nameBrand_Text { get; set; } // марка 
        string nameModel_Text { get; set; } //модель       

        int? ForeignCarOwnerId_Integer { get; set; } // "ссылка на Владельца"
        DateTime dateRelease_DateTime { get; set; } // год выпуска автомобиля

        byte[] carRowVersion_ByteArray { get; set; } // токен параллелизма

        object CarViewItems_Object { get; set; } // для получения элементов для грида от модели    
    }
}
