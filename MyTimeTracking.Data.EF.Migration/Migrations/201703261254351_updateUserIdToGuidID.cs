namespace MyTimeTracking.Data.EF.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserIdToGuidID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
