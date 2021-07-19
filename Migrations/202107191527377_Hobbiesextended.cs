namespace EFDbFirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hobbiesextended : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Photography", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Gardening", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Dance", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Hiking", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Painting", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Painting");
            DropColumn("dbo.Users", "Hiking");
            DropColumn("dbo.Users", "Dance");
            DropColumn("dbo.Users", "Gardening");
            DropColumn("dbo.Users", "Photography");
        }
    }
}
