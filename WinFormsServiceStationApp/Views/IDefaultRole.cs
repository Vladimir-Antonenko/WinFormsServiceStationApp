using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IDefaultRole
    {
        int roleId_Integer { get; set; } // ключ номер должности
        string NameSpeciality_Text { get; set; } // наименование специальности

        object roleList_Object { get; set; } // для отображения списка работ

        byte[] roleRowVersion_ByteArray { get; set; } // для параллелизма
    }
}
