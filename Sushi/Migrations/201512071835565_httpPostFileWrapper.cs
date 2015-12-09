namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class httpPostFileWrapper : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MenuItems", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuItems", "Picture", c => c.String());
        }
    }
}
