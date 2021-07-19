namespace EFDbFirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HobbiesString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Hobbies", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Hobbies");
        }
    }
}
