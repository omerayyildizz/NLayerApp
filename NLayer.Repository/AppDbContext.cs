using Microsoft.EntityFrameworkCore;
using NLayer.Core.Model;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//var p = new Product() { new ProductFeature {Id=1, } } product eklenirken direk olarak productfeature ekletme işlemi de bu şekilde yapılabilir
namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//Interfaceye sahip tüm classları bulmak için çalışmış olunan assemblyleri tarıyor.
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());//tek tek bu şekildede verilebilir.
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id = 1,
                Color = "Kırmızı",
                Height = 80,
                Width = 30,
                ProductId = 1
            }, new ProductFeature()
            {
                Id = 2,
                Color = "Mavi",
                Height = 14,
                Width = 3,
                ProductId = 2
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
