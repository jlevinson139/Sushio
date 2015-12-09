namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPics : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "Picture");
        }
    }
}
