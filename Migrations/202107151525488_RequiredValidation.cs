namespace EFDbFirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "AvailabilityStatus", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "AvailabilityStatus", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ProductName", c => c.String());
        }
    }
}
