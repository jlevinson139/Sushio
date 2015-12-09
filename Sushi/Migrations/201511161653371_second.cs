namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(),
                        Cost = c.Single(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        timeSent = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.MenuItems", new[] { "Order_OrderId" });
            DropTable("dbo.Orders");
            DropTable("dbo.MenuItems");
        }
    }
}
