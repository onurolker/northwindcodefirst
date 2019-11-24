namespace Northwind.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Orders_OrderId = c.Int(),
                        Products_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.Orders", t => t.Orders_OrderId)
                .ForeignKey("dbo.Products", t => t.Products_ProductId)
                .Index(t => t.Orders_OrderId)
                .Index(t => t.Products_ProductId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ShipName = c.String(nullable: false, maxLength: 50),
                        ShippingAddress = c.String(nullable: false, maxLength: 250),
                        OrderDate = c.DateTime(nullable: false, storeType: "date"),
                        Description = c.String(nullable: false, maxLength: 2000),
                        ShippingType = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        PurchasePrice = c.Decimal(nullable: false, storeType: "money"),
                        SellPrice = c.Decimal(nullable: false, storeType: "money"),
                        UnitsInStock = c.Int(nullable: false),
                        ProductStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "Products_ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "Orders_OrderId", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropIndex("dbo.OrderDetails", new[] { "Products_ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "Orders_OrderId" });
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
        }
    }
}
