namespace EFDbFirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MobileAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Mobile", c => c.String());
            DropColumn("dbo.Users", "Hobbies");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Hobbies", c => c.String());
            DropColumn("dbo.Users", "Mobile");
        }
    }
}
