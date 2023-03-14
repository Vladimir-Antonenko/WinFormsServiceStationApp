namespace WinFormsServiceStationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class created8 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.WorkOrderWork", newName: "WorkOrderWorks");
            DropPrimaryKey("dbo.WorkOrderWorks");
            AddPrimaryKey("dbo.WorkOrderWorks", new[] { "WorkId", "WorkOrderId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WorkOrderWorks");
            AddPrimaryKey("dbo.WorkOrderWorks", new[] { "WorkOrderId", "WorkId" });
            RenameTable(name: "dbo.WorkOrderWorks", newName: "WorkOrderWork");
        }
    }
}
