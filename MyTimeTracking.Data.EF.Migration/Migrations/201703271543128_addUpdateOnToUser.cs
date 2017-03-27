namespace MyTimeTracking.Data.EF.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUpdateOnToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UpdateOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UpdateOn");
        }
    }
}
