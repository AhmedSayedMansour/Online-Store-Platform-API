namespace OnlineStorePlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnlineStoreDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false, maxLength: 256),
                        password = c.String(),
                        userName = c.String(),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "email" });
            DropTable("dbo.Users");
        }
    }
}
