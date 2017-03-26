namespace MyTimeTracking.Data.EF.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        PassWord = c.String(),
                        UserName = c.String(),
                        ProfileGravatar = c.String(),
                        UserType = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
