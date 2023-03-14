using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class Owner : UniTable
    {
        public string FullName { get; set; } // имя пользователя
        public string Adress { get; set; } // адрес проживания
        public string NumPassport { get; set; } // даненые паспорта
        public string Phone { get; set; } // контактный телефон


        public virtual ICollection<Car> Cars { get; set; }

        public Owner()
        {
            Cars = new List<Car>();  // для связи Owner с Cars по схеме один ко многим
        }

        public override string ToString()
        {
            return FullName;
            //  return NameBrand + " " + NameModel + " VIN/№кузова" + VIN;
        }

        public static int? FindOwner(string passportOwner = "")  // поиск по паспорту
        {
            int? find = null;

            using (ServiceStationContext context = new ServiceStationContext())
            {
                var owner = context.Owners.Where(x => x.NumPassport == passportOwner).FirstOrDefault();

                if (owner == null)
                {
                    find = null;
                }
                else
                {
                    find = owner.Id;
                }             
            }

            return find;
        }
    }
}
