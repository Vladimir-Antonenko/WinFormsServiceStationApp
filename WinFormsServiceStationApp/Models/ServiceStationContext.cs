using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsServiceStationApp.Models
{
    class ServiceStationContext : DbContext
    {
        public ServiceStationContext()
         : base("name=ServiceStationContext") { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<DefaultRole> DefaultRoles { get; set; }
        public DbSet<DefaultOrderState> DefaultOrderStates { get; set; }
        public DbSet<WorkOrderWork> WorkOrderWork { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            // Car
            // токен параллелизма
            builder.Entity<Car>().
                    Property(p => p.RowVersion).
                    IsRowVersion();

            builder.Entity<Car>().
                Property(r => r.VIN).
                IsRequired().
                HasMaxLength(50).
                HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index_Car") { IsUnique = true } }));

            // HasRequired запрещает быть нулевым внешнему ключу
            // HasMany() устанавливает множественную связь между объектом WorkOrder и объектами Acceptor. 
            // А метод WithMany() добавляет обратную множественную связь между объектом Acceptor и объектами WorkOrder.

            builder.Entity<WorkOrderWork>().HasKey(sc => new { sc.WorkId, sc.WorkOrderId });

            builder.Entity<WorkOrderWork>().HasRequired<Work>(sc => sc.Work)
                    .WithMany(s => s.WorkOrderWorks)
                    .HasForeignKey(sc => sc.WorkId);

            builder.Entity<WorkOrderWork>()
                .HasRequired<WorkOrder>(sc => sc.WorkOrder)
                .WithMany(s => s.WorkOrderWorks)
                .HasForeignKey(sc => sc.WorkOrderId);
    
            // Owner
            // токен параллелизма
            builder.Entity<Owner>().
                    Property(p => p.RowVersion).
                    IsRowVersion();

            builder.Entity<Owner>().
                Property(r => r.NumPassport).
                IsRequired().
                HasMaxLength(50).
                HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index_NumPass") { IsUnique = true } }));


            // токен параллелизма
            builder.Entity<Work>().
                    Property(p => p.RowVersion).
                    IsRowVersion();

            builder.Entity<Work>().
               Property(r => r.NameWorks).
               IsRequired().
               HasMaxLength(100).
               HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index_Work") { IsUnique = true } }));

            // токен параллелизма
            builder.Entity<Worker>().
                    Property(p => p.RowVersion).
                    IsRowVersion();

            builder.Entity<Worker>().HasRequired(i => i.DefaultRole).WithMany().HasForeignKey(i => i.DefaultRoleId).WillCascadeOnDelete(false);
            builder.Entity<Worker>().
               Property(r => r.NumPassport).
               IsRequired().
               HasMaxLength(50).
               HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index_Worker") { IsUnique = true } }));


            // токен параллелизма
            builder.Entity<WorkOrder>().
                    Property(p => p.RowVersion).
                    IsRowVersion();

            // настройка внешних ключей
            builder.Entity<WorkOrder>().HasRequired(i => i.Acceptor).WithMany().HasForeignKey(i => i.AcceptorId).WillCascadeOnDelete(false);
            builder.Entity<WorkOrder>().HasRequired(i => i.Master).WithMany().HasForeignKey(i => i.MasterId).WillCascadeOnDelete(false);
            builder.Entity<WorkOrder>().HasRequired(i => i.Owner).WithMany().HasForeignKey(i => i.OwnerId).WillCascadeOnDelete(false);
            builder.Entity<WorkOrder>().HasRequired(i => i.OrderState).WithMany().HasForeignKey(i => i.OrderStateId).WillCascadeOnDelete(false);
            builder.Entity<WorkOrder>().HasRequired(i => i.Car).WithMany().HasForeignKey(i => i.CarId).WillCascadeOnDelete(false);
            //builder.Entity<WorkOrder>().HasMany(i => i.Works); // ЗАКОММЕНТИЛ изза добавления многие ко многим надо проверить что ок

            // токен параллелизма
            builder.Entity<DefaultRole>().
                    Property(p => p.RowVersion).
                    IsRowVersion();

            // токен параллелизма
            builder.Entity<DefaultOrderState>().
                    Property(p => p.RowVersion).
                    IsRowVersion();


            base.OnModelCreating(builder);
        }
    }
}

// для миграций
//PM> Enable-Migrations -аааа
//PM > Add - Migration created
//   PM> Update-Database –Verbose