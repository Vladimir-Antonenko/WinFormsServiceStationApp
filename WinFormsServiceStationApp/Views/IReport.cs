using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Views
{
    public interface IReport
    {
        object DataJournalWorkOrderList { get; set; } // данные для отчета
        object DataOwnerList { get; set; } // данные для отчета
        object DataСarList { get; set; } // данные для отчета
        object DataAcceptorList { get; set; } // данные для отчета
        object DataMasterList { get; set; } // данные для отчета
        object DataWokrsList { get; set; } // данные для отчета
    }
}
