using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seed
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                Name = "Polo yaka",
                CategoryId = 1,
                Price = 999,
                Stock = 100,
                CreatedDate = DateTime.Now
            },
                new Product
                {
                    Id = 2,
                    Name = "Iphone13",
                    CategoryId = 2,
                    Price = 39999,
                    Stock = 100,
                    CreatedDate = DateTime.Now
                }
                , new Product
                {
                    Id = 3,
                    Name = "Sucuk",
                    CategoryId = 3,
                    Price = 90,
                    Stock = 100,
                    CreatedDate = DateTime.Now
                },
                new Product
                {
                    Id = 4,
                    Name = "Iphone13Pro",
                    CategoryId = 2,
                    Price = 49500,
                    Stock = 100,
                    CreatedDate = DateTime.Now
                }, new Product
                {
                    Id = 5,
                    Name = "Gömlek",
                    CategoryId = 1,
                    Price = 300,
                    Stock = 100,
                    CreatedDate = DateTime.Now
                }
                );
        }
    }
}
