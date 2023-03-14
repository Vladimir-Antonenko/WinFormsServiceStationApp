using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IWork
    {
        int workId_Integer { get; set; } // ключ номер работы
        string nameWorks_Text { get; set; } // наименование работы
        double price_Double { get; set; } // цена работы

        object WorkList_Object { get; set; } // для отображения списка работ в Гриде

        object WorkListLISTBOX_Object { set; get; } // работы для листбокса

        byte[] workRowVersion_ByteArray { get; set; } // для параллелизма
    }
}
