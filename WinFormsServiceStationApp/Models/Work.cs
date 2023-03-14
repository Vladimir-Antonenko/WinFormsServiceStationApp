using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class Work : UniTable
    {
        public string NameWorks { get; set; } // наименование работы
        public double Price { get; set; } // наименование работы

        public virtual ICollection<WorkOrderWork> WorkOrderWorks { get; set; }

        // public virtual ICollection<WorkOrder> WorkOrders { get; set; }

        public Work()
        {
            WorkOrderWorks = new List<WorkOrderWork>();

            //  WorkOrders = new List<WorkOrder>();  // для связи многие ко многим
        }

        public override string ToString()
        {
            return NameWorks;
        }

        public static List<Work> GetData_WORKs(List<int> indexes = null)
        {
            List<Work> ListWork = null;

            using (ServiceStationContext context = new ServiceStationContext())
            {
                if (indexes != null)
                {
                    ListWork = (from p in context.Works // данные работ для загруженных данных
                                join c in context.WorkOrderWork on p.Id equals c.WorkId
                                where indexes.Contains(c.WorkOrderId)
                                orderby p.Id
                                select p).Distinct().ToList();
                }
            }

            return ListWork;
        }

        public static List<Work> lllistWorks(int i) // список работ для конкретного заказ-наряда
        {
            using (ServiceStationContext context = new ServiceStationContext())
            {
                return (from p in context.Works // данные работ для загруженных данных
                            join c in context.WorkOrderWork on p.Id equals c.WorkId
                            where i == c.WorkOrderId
                            orderby p.Id
                            select p).Distinct().ToList();
            }
        }
    }
}
