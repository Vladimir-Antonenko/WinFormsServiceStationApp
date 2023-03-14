using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    public class DefaultRole : UniTable
    {
        public string NameSpeciality { get; set; } // наименование должность/специальность

        //public virtual ICollection<Worker> Workers { get; set; }
        //public DefaultRole()
        //{
        //    Workers = new List<Worker>();
        //}

        public override string ToString()
        {
            return NameSpeciality;
        }
    }
}
