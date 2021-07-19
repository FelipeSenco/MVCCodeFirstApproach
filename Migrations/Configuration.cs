namespace EFDbFirstApproachExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDbFirstApproachExample.Models.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFDbFirstApproachExample.Models.CompanyDbContext context)
        {
            context.Brands.AddOrUpdate(new Models.Brand() { BrandID = 1, BrandName = "Sony" });
            context.Categories.AddOrUpdate(new Models.Category() { CategoryID = 1, CategoryName = "Mobile" });
            context.Products.AddOrUpdate(new Models.Product() { ProductID=1, ProductName="Xperia", CategoryID=1, BrandID=1, DateOfPurchase=DateTime.Now, Active=true, AvailabilityStatus="InStock", Price=1000});
        }
    }
}
