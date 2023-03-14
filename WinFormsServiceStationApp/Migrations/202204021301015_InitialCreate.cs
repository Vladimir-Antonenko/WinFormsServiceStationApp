namespace WinFormsServiceStationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VIN = c.String(nullable: false, maxLength: 50),
                        NumReg = c.String(),
                        NameBrand = c.String(),
                        NameModel = c.String(),
                        DateRelease = c.DateTime(),
                        OwnerId = c.Int(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owners", t => t.OwnerId)
                .Index(t => t.VIN, unique: true, name: "Index_Car")
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Adress = c.String(),
                        NumPassport = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NumPassport, unique: true, name: "Index_NumPass");
            
            CreateTable(
                "dbo.DefaultOrderStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateWork = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DefaultRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSpeciality = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Phone = c.String(),
                        NumPassport = c.String(nullable: false, maxLength: 50),
                        DefaultRoleId = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DefaultRoles", t => t.DefaultRoleId)
                .Index(t => t.NumPassport, unique: true, name: "Index_Worker")
                .Index(t => t.DefaultRoleId);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrentDate = c.DateTime(nullable: false),
                        OrderStateId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        CommentOwners = c.String(),
                        OwnerId = c.Int(nullable: false),
                        AcceptorId = c.Int(nullable: false),
                        MasterId = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.AcceptorId)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .ForeignKey("dbo.Workers", t => t.MasterId)
                .ForeignKey("dbo.DefaultOrderStates", t => t.OrderStateId)
                .ForeignKey("dbo.Owners", t => t.OwnerId)
                .Index(t => t.OrderStateId)
                .Index(t => t.CarId)
                .Index(t => t.OwnerId)
                .Index(t => t.AcceptorId)
                .Index(t => t.MasterId);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameWorks = c.String(nullable: false, maxLength: 100),
                        Price = c.Double(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NameWorks, unique: true, name: "Index_Work");
            
            CreateTable(
                "dbo.WorkWorkOrders",
                c => new
                    {
                        Work_Id = c.Int(nullable: false),
                        WorkOrder_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Work_Id, t.WorkOrder_Id })
                .ForeignKey("dbo.Works", t => t.Work_Id, cascadeDelete: true)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrder_Id, cascadeDelete: true)
                .Index(t => t.Work_Id)
                .Index(t => t.WorkOrder_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkWorkOrders", "WorkOrder_Id", "dbo.WorkOrders");
            DropForeignKey("dbo.WorkWorkOrders", "Work_Id", "dbo.Works");
            DropForeignKey("dbo.WorkOrders", "OwnerId", "dbo.Owners");
            DropForeignKey("dbo.WorkOrders", "OrderStateId", "dbo.DefaultOrderStates");
            DropForeignKey("dbo.WorkOrders", "MasterId", "dbo.Workers");
            DropForeignKey("dbo.WorkOrders", "CarId", "dbo.Cars");
            DropForeignKey("dbo.WorkOrders", "AcceptorId", "dbo.Workers");
            DropForeignKey("dbo.Workers", "DefaultRoleId", "dbo.DefaultRoles");
            DropForeignKey("dbo.Cars", "OwnerId", "dbo.Owners");
            DropIndex("dbo.WorkWorkOrders", new[] { "WorkOrder_Id" });
            DropIndex("dbo.WorkWorkOrders", new[] { "Work_Id" });
            DropIndex("dbo.Works", "Index_Work");
            DropIndex("dbo.WorkOrders", new[] { "MasterId" });
            DropIndex("dbo.WorkOrders", new[] { "AcceptorId" });
            DropIndex("dbo.WorkOrders", new[] { "OwnerId" });
            DropIndex("dbo.WorkOrders", new[] { "CarId" });
            DropIndex("dbo.WorkOrders", new[] { "OrderStateId" });
            DropIndex("dbo.Workers", new[] { "DefaultRoleId" });
            DropIndex("dbo.Workers", "Index_Worker");
            DropIndex("dbo.Owners", "Index_NumPass");
            DropIndex("dbo.Cars", new[] { "OwnerId" });
            DropIndex("dbo.Cars", "Index_Car");
            DropTable("dbo.WorkWorkOrders");
            DropTable("dbo.Works");
            DropTable("dbo.WorkOrders");
            DropTable("dbo.Workers");
            DropTable("dbo.DefaultRoles");
            DropTable("dbo.DefaultOrderStates");
            DropTable("dbo.Owners");
            DropTable("dbo.Cars");
        }
    }
}
