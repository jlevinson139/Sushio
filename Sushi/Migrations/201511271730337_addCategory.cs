namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "Category");
        }
    }
}
