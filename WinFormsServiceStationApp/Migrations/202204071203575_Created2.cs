namespace WinFormsServiceStationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Created2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Works", "Index_Work");
            AlterColumn("dbo.Works", "NameWorks", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Works", "NameWorks", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Works", "NameWorks", unique: true, name: "Index_Work");
        }
    }
}
