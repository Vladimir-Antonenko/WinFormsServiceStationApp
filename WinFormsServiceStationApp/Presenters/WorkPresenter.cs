using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Views;
using WinFormsServiceStationApp.Models;

namespace WinFormsServiceStationApp.Presenters
{
    public class WorkPresenter
    {
        IWork WorkView;

        public WorkPresenter(IWork view)
        {
            WorkView = view;
        }

        public void AddWorkElem()
        {
            Work work = new Work();
            work.NameWorks = WorkView.nameWorks_Text.Trim();
            work.Price = WorkView.price_Double;
          
            var crud = new Crud<Work>(); // репозиторий 
            crud.Create(work, x => x.NameWorks == work.NameWorks); // задаем добавляемую entity и поле по которому проверим есть уже элемент или нет в таблице         
        }

        public void GetListWorks()
        {
            var crud = new Crud<Work>();
            WorkView.WorkList_Object = crud.GetAll();
        }

        public void GetMyWorks(int i)
        {
            WorkView.WorkListLISTBOX_Object = Work.lllistWorks(i);
        }
    }
}
