namespace OnlineStorePlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OnlineStoreDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "userName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "userName", c => c.String());
            AlterColumn("dbo.Users", "password", c => c.String());
        }
    }
}
