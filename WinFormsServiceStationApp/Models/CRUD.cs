using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using LinqKit;

namespace WinFormsServiceStationApp.Models
{
    public class Crud<T> : IDisposable where T : UniTable // репозиторий
    {
        private readonly ServiceStationContext _context;

        public Crud()
        {
            _context = new ServiceStationContext();
        }

        public List<T> GetWithBindData(string pathNavigation = "")
        {
            if (pathNavigation != "")
                return _context.Set<T>().Include(pathNavigation).Take(200).AsNoTracking().ToList();
            else
                return _context.Set<T>().Take(200).AsNoTracking().ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().Take(1000).AsNoTracking().ToList();
        }

        public virtual List<T> GetByFilter(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.AsExpandable().Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).Take(200).ToList();
            }
            else
            {
                return query.Take(200).ToList();
            }
        }

        //Код Expression<Func<TEntity, bool>> filter означает, что вызывающий объект предоставит лямбда-выражение
        //на основе TEntity типа, и это выражение возвратит логическое значение.
        //Например, если создается экземпляр репозитория для Car типа сущности,
        //то код в вызывающем методе может указать
        // car => Car.ViN == "S112 "для filter параметра.

        public virtual void Create(T entity, Expression<Func<T, bool>> filter = null)  // желательно отправлять в filter для добавления поле, на основе которого убедимся, что элемент в таблице не был добавлен ранее
        {
            if (filter != null)
            {
                var dbEntity = GetByFilter(filter).FirstOrDefault();
                if (dbEntity != null)
                {
                    throw new NotImplementedException("Объект в БД уже существует! Операция прервана, объект в таблицу не добавлен!");
                }
            }
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            var dbEntity = _context.Set<T>().Find(entity.Id);
            if (dbEntity == null)
            {
                throw new NotImplementedException("Объект не найден. Обработка этого исключения находится на стадии разработки");
            }

            _context.Entry(dbEntity).CurrentValues.SetValues(entity); // аналогом будет state is modified (не изменяет навигационные поля)
           
            _context.SaveChanges();
        }

        public void UpdateValues (T modifiedEntity, string navigationNames = "") // не сработало для навигационного свойства но задумка верная
        {
            var originalEntity = _context.Set<T>().Find(modifiedEntity.Id);
            if (originalEntity == null)
            {
                throw new NotImplementedException("Объект не найден. Обработка этого исключения находится на стадии разработки");
            }

            //Set non-nav props
            _context.Entry(originalEntity).CurrentValues.SetValues(modifiedEntity); // аналогом будет state is modified (не изменяет навигационные поля)

            if (navigationNames != "")
            {
                //Set nav props
                var navProps = GetNavigationProperties(originalEntity);

                foreach (var navigProperty in navigationNames.Split
                   (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    foreach (var navProp in navProps)
                    {
                        if (navProp.Name == navigProperty)
                        {
                            //Set originalEntity prop value to modifiedEntity value
                            navProp.SetValue(originalEntity, navProp.GetValue(modifiedEntity)); // не работает для навигационной таблицы
                            break;
                        }
                    }
                }
            }

            _context.SaveChanges();
        }

        public List<System.Reflection.PropertyInfo> GetNavigationProperties(T entity)
        {
            List<System.Reflection.PropertyInfo> properties = new List<System.Reflection.PropertyInfo>();
            //Get the entity type
            Type entityType = entity.GetType();
            //Get the System.Data.Entity.Core.Metadata.Edm.EntityType
            //associated with the entity.
            var entitySetElementType = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)_context).ObjectContext.CreateObjectSet<T>().EntitySet.ElementType;
            //Iterate each 
            //System.Data.Entity.Core.Metadata.Edm.NavigationProperty
            //in EntityType.NavigationProperties, get the actual property 
            //using the entityType name, and add it to the return set.
            foreach (var navigationProperty in entitySetElementType.NavigationProperties)
            {
                properties.Add(entityType.GetProperty(navigationProperty.Name));
            }
            return properties;
        }



        public virtual List<T> FindAndReturnElemByKey_ToList(object key)
        {     
            var dbEntity = _context.Set<T>().Find(key);

            return dbEntity != null ? new List<T>() { dbEntity } : null;
        }

        //public virtual void Remove(T entity)
        //{
        //    if (_context.Entry(entity).State == EntityState.Detached)
        //    {
        //        _context.Set<T>().Attach(entity);
        //    }
        //    _context.Set<T>().Remove(entity);
        //    _context.SaveChanges();
        //}

        public virtual void Delete(object id)
        {
            T entityToDelete = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entityToDelete);
            _context.SaveChanges();
        }

        public virtual void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _context.Set<T>().Attach(entityToDelete);
            }
            _context.Set<T>().Remove(entityToDelete);
            _context.SaveChanges();
        }


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

