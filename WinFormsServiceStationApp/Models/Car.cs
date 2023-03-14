using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WinFormsServiceStationApp.Models
{
    public class Car : UniTable
    {
        public string VIN { get; set; } // вин или номер кузова
        public string NumReg { get; set; } //госномер 
        public string NameBrand { get; set; } // марка 
        public string NameModel { get; set; } //модель       
        public DateTime? DateRelease { get; set; } // год выпуска автомобиля
        public int? OwnerId { get; set; } // внешний ключ
        public virtual Owner Owner { get; set; } // навигационное свойство


        public override string ToString() => NameBrand + " " + NameModel + " VIN/№кузова:" + VIN;

        public static void ChangeOwner(Car entity)
        {
            using (ServiceStationContext context = new ServiceStationContext())
            {
                var dbEntity = context.Cars.Find(entity.Id);
                if (dbEntity == null)
                {
                    throw new NotImplementedException("Объект не найден. Обработка этого исключения находится на стадии разработки");
                }
                dbEntity.OwnerId = entity.OwnerId;
                context.Entry(dbEntity).State = EntityState.Modified;         
                context.SaveChanges();
            }
        }

        public static List<string> GetVIN_And_Owner_byKey(int key) // получить VIN и владельца текстом в виде списка
        {
            List<string> Vin_And_Owner_Text = null;

            using (ServiceStationContext context = new ServiceStationContext())
            {
                var dbEntity = context.Cars.Find(key);
                if (dbEntity == null)
                {
                    throw new NotImplementedException("Объект не найден. Обработка этого исключения находится на стадии разработки");
                }
                Vin_And_Owner_Text = new List<string>();
                Vin_And_Owner_Text.Add(dbEntity.VIN);
                Vin_And_Owner_Text.Add(dbEntity.Owner.FullName);
            }

            return Vin_And_Owner_Text;
        }
    }
}
