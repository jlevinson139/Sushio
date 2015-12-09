namespace Sushi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringPic : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuItems", "Picture", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuItems", "Picture", c => c.Binary());
        }
    }
}
