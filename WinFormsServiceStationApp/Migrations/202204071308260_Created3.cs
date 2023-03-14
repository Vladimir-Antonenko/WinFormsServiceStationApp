namespace WinFormsServiceStationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Created3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.WorkWorkOrders", newName: "WorkOrderWork");
            RenameColumn(table: "dbo.WorkOrderWork", name: "Work_Id", newName: "WorkId");
            RenameColumn(table: "dbo.WorkOrderWork", name: "WorkOrder_Id", newName: "WorkOrderId");
            RenameIndex(table: "dbo.WorkOrderWork", name: "IX_WorkOrder_Id", newName: "IX_WorkOrderId");
            RenameIndex(table: "dbo.WorkOrderWork", name: "IX_Work_Id", newName: "IX_WorkId");
            DropPrimaryKey("dbo.WorkOrderWork");
            AddPrimaryKey("dbo.WorkOrderWork", new[] { "WorkOrderId", "WorkId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WorkOrderWork");
            AddPrimaryKey("dbo.WorkOrderWork", new[] { "Work_Id", "WorkOrder_Id" });
            RenameIndex(table: "dbo.WorkOrderWork", name: "IX_WorkId", newName: "IX_Work_Id");
            RenameIndex(table: "dbo.WorkOrderWork", name: "IX_WorkOrderId", newName: "IX_WorkOrder_Id");
            RenameColumn(table: "dbo.WorkOrderWork", name: "WorkOrderId", newName: "WorkOrder_Id");
            RenameColumn(table: "dbo.WorkOrderWork", name: "WorkId", newName: "Work_Id");
            RenameTable(name: "dbo.WorkOrderWork", newName: "WorkWorkOrders");
        }
    }
}
