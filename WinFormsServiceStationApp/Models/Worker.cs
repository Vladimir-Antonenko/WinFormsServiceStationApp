using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class Worker : UniTable
    {
        public string FullName { get; set; } // имя рабочего
        public string Phone { get; set; } // контактный телефон
        public string NumPassport { get; set; } // данные паспорта

        public int? DefaultRoleId { get; set; }  // id должность из таблицы DefaultRole
        public virtual DefaultRole DefaultRole { get; set; } // навигационное

        public override string ToString()
        {
            return FullName;
        }
    }
}
