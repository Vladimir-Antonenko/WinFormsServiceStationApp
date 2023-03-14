using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class WorkOrderWork // смежная таблица чтобы разрешить связь многие ко многим
    {
        public int WorkOrderId { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
  
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
