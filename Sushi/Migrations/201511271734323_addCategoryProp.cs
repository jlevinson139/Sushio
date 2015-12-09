namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategoryProp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("dbo.MenuItems", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.MenuItems", "Category_CategoryId");
            AddForeignKey("dbo.MenuItems", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.MenuItems", new[] { "Category_CategoryId" });
            DropColumn("dbo.MenuItems", "Category_CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
