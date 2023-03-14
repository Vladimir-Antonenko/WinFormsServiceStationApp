using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Models;
using WinFormsServiceStationApp.Views;

namespace WinFormsServiceStationApp.Presenters
{
    public class CarPresenter
    {
        ICar CarView;

        public CarPresenter(ICar view)
        {
            CarView = view;
        }

        public void AddCarElem()
        {
            Car car = new Car();
            car.VIN = CarView.VIN_Text.Trim();
            car.NameBrand = CarView.nameBrand_Text.Trim();
            car.NameModel = CarView.nameModel_Text.Trim();
            car.NumReg = CarView.numReg_Text.Trim();
            car.DateRelease = CarView.dateRelease_DateTime;
            car.OwnerId = CarView.ForeignCarOwnerId_Integer;

            var crud = new Crud<Car>(); // репозиторий 
            crud.Create(car, x => x.VIN == car.VIN); // задаем добавляемую entity и поле по которому проверим есть уже элемент или нет в таблице         
        }

        public void GetCarTable()
        {
            var crud = new Crud<Car>();
            CarView.CarViewItems_Object = crud.GetWithBindData();
        }

        public void GetCarTableOnlyWithOwners()
        {
            Expression<Func<Car, bool>> filterOwnerIdNOTNULL = x => x.OwnerId != null;

            var crud = new Crud<Car>();
            CarView.CarViewItems_Object = crud.GetByFilter(filterOwnerIdNOTNULL);

        }

        public void ChangeOwner()
        {
            Car car = new Car();
            car.Id = CarView.CarId_Integer;
            car.OwnerId = CarView.ForeignCarOwnerId_Integer;
            car.RowVersion = CarView.carRowVersion_ByteArray;

            Car.ChangeOwner(car);
        }

        public void UpdateCarElem()
        {
            Car car = new Car();
            car.Id = CarView.CarId_Integer;
            car.VIN = CarView.VIN_Text.Trim();
            car.NameBrand = CarView.nameBrand_Text.Trim();
            car.NameModel = CarView.nameModel_Text.Trim();
            car.NumReg = CarView.numReg_Text.Trim();
            car.DateRelease = CarView.dateRelease_DateTime;
            car.OwnerId = CarView.ForeignCarOwnerId_Integer;
            car.RowVersion = CarView.carRowVersion_ByteArray;

            var crud = new Crud<Car>(); // репозиторий 
            crud.Update(car); // задаем обновляемую entity
        }

        public void SearchByManyPatameters() // поиск по параметрам (по-хорошему нужно создавать дерево параметров для фильтрации)
        {
            List<Expression<Func<Car, bool>>> filterList = new List<Expression<Func<Car, bool>>>();

            if (CarView.VIN_Text != "")
            {
                filterList.Add(x => x.VIN.Contains(CarView.VIN_Text));
            }
            if (CarView.nameBrand_Text != "")
            {
                filterList.Add(x => x.NameBrand.Contains(CarView.nameBrand_Text));
            }
            if (CarView.nameModel_Text != "")
            {
                filterList.Add(x => x.NameModel.Contains(CarView.nameModel_Text));
            }

            if (CarView.numReg_Text != "")
            {
                filterList.Add(x => x.NumReg.Contains(CarView.numReg_Text));
            }

            Expression<Func<Car, bool>> filter = null;

            foreach (var e in filterList)
                filter = filter.And(e);

            var crud = new Crud<Car>();
            CarView.CarViewItems_Object = crud.GetByFilter(filter);
        }

         public void SearchByManyPatametersWithOwnerONLY() // поиск по параметрам (по-хорошему нужно создавать дерево параметров для фильтрации)
        {
            List<Expression<Func<Car, bool>>> filterList = new List<Expression<Func<Car, bool>>>();

            filterList.Add(x => x.OwnerId!=null); /// !!!!!!!!!!!!!!!! // только условие поиска только с владельцами авто

            if (CarView.VIN_Text != "")
            {
                filterList.Add(x => x.VIN.Contains(CarView.VIN_Text));
            }
            if (CarView.nameBrand_Text != "")
            {
                filterList.Add(x => x.NameBrand.Contains(CarView.nameBrand_Text));
            }
            if (CarView.nameModel_Text != "")
            {
                filterList.Add(x => x.NameModel.Contains(CarView.nameModel_Text));
            }

            if (CarView.numReg_Text != "")
            {
                filterList.Add(x => x.NumReg.Contains(CarView.numReg_Text));
            }

            Expression<Func<Car, bool>> filter = null;

            foreach (var e in filterList)
                filter = filter.And(e);

            var crud = new Crud<Car>();
            CarView.CarViewItems_Object = crud.GetByFilter(filter);
        }
    }
}
