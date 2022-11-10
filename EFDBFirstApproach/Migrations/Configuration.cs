namespace EFDBFirstApproach.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDBFirstApproach.Models.EFCFADbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFDBFirstApproach.Models.EFCFADbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Brands.AddOrUpdate(new Models.Brand() { BrandID = 1, BrandName = "SteelSeries" }, new Models.Brand() {BrandID =2, BrandName = "Sony" });
            context.Categories.AddOrUpdate(new Models.Category() { CategoryID = 1, CategoryName = "Electronics" }, new Models.Category() { CategoryID = 2, CategoryName = "Computer Appliances" });
            context.Products.AddOrUpdate(new Models.Product() { ProductID = 1, ProductName = "Artics 7", Price = 1200, Active = true, AvailabilityStatus = "InStock", BrandID = 1, CategoryID = 2, DateOfPurchase = DateTime.Now, Photo = null });
        }
    }
}
