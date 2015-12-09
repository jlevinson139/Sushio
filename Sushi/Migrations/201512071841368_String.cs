namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class String : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "Picture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "Picture");
        }
    }
}
