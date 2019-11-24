namespace Northwind.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setUser2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Firstname", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Firstname", c => c.String(nullable: false));
        }
    }
}
