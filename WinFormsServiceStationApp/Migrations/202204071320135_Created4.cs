namespace WinFormsServiceStationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Created4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Works", "NameWorks", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Works", "NameWorks", unique: true, name: "Index_Work");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Works", "Index_Work");
            AlterColumn("dbo.Works", "NameWorks", c => c.String());
        }
    }
}
