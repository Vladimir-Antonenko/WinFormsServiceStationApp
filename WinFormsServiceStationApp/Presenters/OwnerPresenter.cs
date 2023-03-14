using QueryDesignerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions; //
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Models;
using WinFormsServiceStationApp.Views;

namespace WinFormsServiceStationApp.Presenters
{
    public class OwnerPresenter
    {
        IOwner OwnerView;

        public OwnerPresenter(IOwner view)
        {
            OwnerView = view;
        }

        public void AddOwnerElem() // добавить владельца
        {
            Owner owner = new Owner();
            owner.NumPassport = OwnerView.NumPassport_Text.Trim();
            owner.Adress = OwnerView.Adress_Text.Trim();
            owner.FullName = OwnerView.FullName_Text.Trim();
            owner.Phone = OwnerView.Phone_Text.Trim();

            var crud = new Crud<Owner>(); // репозиторий 
            crud.Create(owner, x => x.NumPassport == owner.NumPassport); // задаем добавляемую entity и поле по которому проверим есть уже элемент или нет в таблице
        }

        public void UpdateOwnerElem() // Изменить данные владельца
        {
            Owner owner = new Owner();
            owner.Id = OwnerView.ownerId_Integer;
            owner.NumPassport = OwnerView.NumPassport_Text.Trim();
            owner.Adress = OwnerView.Adress_Text.Trim();
            owner.FullName = OwnerView.FullName_Text.Trim();
            owner.Phone = OwnerView.Phone_Text.Trim();
            owner.RowVersion = OwnerView.ownerRowVersion_ByteArray;
 
            var crud = new Crud<Owner>(); // репозиторий 
            crud.Update(owner); // задаем обновляемую entity
        }

        public void GetOwnerTableWithCarsInfo() // получить таблицу владельцы
        {
            var crud = new Crud<Owner>();
            OwnerView.OwnerViewItems_Object = crud.GetWithBindData("Cars");
        }

        public int? FindOwner() // поиск владельца по паспорту
        {
            string Passport = OwnerView.NumPassport_Text.Trim();
            return Owner.FindOwner(Passport);
        }

        public void FindAndGetOneElemForGrid(int? findOwnerKey) // поиск владельца по ключу и извлечение его в Грид
        {
            if (findOwnerKey != null)
            {
                var crud = new Crud<Owner>();
                OwnerView.OwnerViewItems_Object = crud.FindAndReturnElemByKey_ToList((int)findOwnerKey);      
            }
            else
            {
                OwnerView.OwnerViewItems_Object = null;  // ошибка, ключ нулевой
            }
        }

        public void SearchByManyPatameters() // поиск по параметрам (по-хорошему нужно создавать дерево параметров для фильтрации)
        {
            List<Expression<Func<Owner, bool>>> filterList = new List<Expression<Func<Owner, bool>>>();

            if (OwnerView.FullName_Text != "")
            {
                filterList.Add(x => x.FullName.Contains(OwnerView.FullName_Text));
            }
            //if(OwnerView.Adress_Text != "")
            //{
            //    filterList.Add(x => x.Adress.Contains(OwnerView.Adress_Text));
            //}
            if(OwnerView.Phone_Text != "")
            {
                filterList.Add(x => x.Phone.Contains(OwnerView.Phone_Text));
            }
            if(OwnerView.NumPassport_Text != "")
            {
                filterList.Add(x => x.NumPassport.Contains(OwnerView.NumPassport_Text));
            }

            Expression<Func<Owner, bool>> filter = null;

            foreach (var e in filterList)
                filter = filter.And(e);

            var crud = new Crud<Owner>();
            OwnerView.OwnerViewItems_Object = crud.GetByFilter(filter);
        }
    }
}
