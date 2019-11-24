namespace Northwind.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADEDUSER : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false),
                        Lastname = c.String(),
                        MailAddress = c.String(),
                        PhoneNumber = c.String(),
                        UserPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
