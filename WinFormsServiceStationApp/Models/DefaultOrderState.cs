using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class DefaultOrderState : UniTable
    {
        public string StateWork { get; set; } // состояние (статус) работы (в работе или нет например)   

        public override string ToString()
        {
            return StateWork;
        }
    }
}
