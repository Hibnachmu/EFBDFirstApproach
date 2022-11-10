using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFDBFirstApproach.Migrations; 
namespace EFDBFirstApproach.Models
{
    public class EFCFADbContext : DbContext
    {
        public EFCFADbContext():base("MyConString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFCFADbContext, Configuration>());
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}