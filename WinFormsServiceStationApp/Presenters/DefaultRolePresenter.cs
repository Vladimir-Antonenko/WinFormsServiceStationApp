using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsServiceStationApp.Views;
using WinFormsServiceStationApp.Models;

namespace WinFormsServiceStationApp.Presenters
{
    public class DefaultRolePresenter
    {
        IDefaultRole DefaultRole_View;

        public DefaultRolePresenter(IDefaultRole view)
        {
            DefaultRole_View = view;
        }

        public void AddRoleElem()
        {
            DefaultRole defaultRole = new DefaultRole();
            defaultRole.NameSpeciality = DefaultRole_View.NameSpeciality_Text.Trim();

            var crud = new Crud<DefaultRole>(); // репозиторий 
            crud.Create(defaultRole); // задаем добавляемую entity         
        }

        public void GetDefaultRoleTable()
        {
            var crud = new Crud<DefaultRole>();
            DefaultRole_View.roleList_Object = crud.GetWithBindData();
        }

        public void UpdateRole()
        {
            DefaultRole defaultRole = new DefaultRole();
            defaultRole.Id = DefaultRole_View.roleId_Integer;
            defaultRole.NameSpeciality = DefaultRole_View.NameSpeciality_Text.Trim();
            defaultRole.RowVersion = DefaultRole_View.roleRowVersion_ByteArray;

            var crud = new Crud<DefaultRole>(); // репозиторий 
            crud.Update(defaultRole); // задаем обновляемую entity
        }

        public void RemoveState()
        {
            DefaultRole defaultRole = new DefaultRole();
            defaultRole.Id = DefaultRole_View.roleId_Integer;
            defaultRole.NameSpeciality = DefaultRole_View.NameSpeciality_Text.Trim();
            defaultRole.RowVersion = DefaultRole_View.roleRowVersion_ByteArray;

            var crud = new Crud<DefaultRole>(); // репозиторий 
            crud.Delete(defaultRole); // задаем удаляемую entity
        }
    }
}
