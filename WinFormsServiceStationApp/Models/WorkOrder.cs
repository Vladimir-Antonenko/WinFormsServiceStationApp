using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class WorkOrder : UniTable
    {
        public DateTime CurrentDate { get; set; } // текущая дата

        public int OrderStateId { get; set; }
        public virtual DefaultOrderState OrderState { get; set; } // состояние (статус) работы (в работе или нет например)   


        public int CarId { get; set; }
        public virtual Car Car { get; set; } // ссылка на авто

        public string CommentOwners { get; set; } // неисправность со слов заказчика, либо его пожелания/комментарии к предстоящей работе

        // public virtual ICollection<Work> Works { get; set; }

        public virtual ICollection<WorkOrderWork> WorkOrderWorks { get; set; }

        public WorkOrder()
        {
            WorkOrderWorks = new List<WorkOrderWork>();
            //  Works = new List<Work>();  // для связи многие ко многим
        }

        public int OwnerId { get; set; }   // id владельца (заявитель)
        public virtual Owner Owner { get; set; }

        public int AcceptorId { get; set; }   // id приемщика 
        public virtual Worker Acceptor { get; set; }

        public int MasterId { get; set; }   // id мастера-исполнителя (работника)
        public virtual Worker Master { get; set; }


        public void UpdateMyWorkOrderRecord(List<WorkOrderWork> newWork) // обновление записи заказ-наряда в одной транзакции
        {
            using (ServiceStationContext context = new ServiceStationContext())
            {
                var dbEntity = context.WorkOrders.Find(Id);
                if (dbEntity == null)
                {
                    throw new NotImplementedException("Объект не найден. Обработка этого исключения находится на стадии разработки");
                }

                context.Entry(dbEntity).CurrentValues.SetValues(this); // лью скалярные значения (не изменяет навигационные поля)

                dbEntity.WorkOrderWorks.Clear(); // очищаю прошлый список работ
                dbEntity.WorkOrderWorks = newWork; // устанавливаю новый

                context.Entry(dbEntity).State = EntityState.Modified; // запись изменена

                context.SaveChanges(); //сохраняю в рамках одной транзакции все выше описанные операции
            }
        }
    }
}
