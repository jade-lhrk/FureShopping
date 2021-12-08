using FureShopping.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FureShopping.Data
{
    public class DataGenerater
    {
        public static void CreateData(IServiceProvider serviceProvider)
        {
            using (var context = new ShopContext(serviceProvider.GetRequiredService<DbContextOptions<ShopContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product()
                    {
                        Id = 1,
                        Name = "Jade",
                        ProductTypeId = 1,
                        Price = 100,
                        Score = 1
                    },
                    new Product()
                    {
                        Id = 2,
                        Name = "Jade2",
                        ProductTypeId = 1,
                        Price = 50,
                        Score = 1
                    },
                    new Product()
                    {
                        Id = 3,
                        Name = "Jade3",
                        ProductTypeId = 1,
                        Price = 100,
                        Score = 1
                    },
                    new Product()
                    {
                        Id = 4,
                        Name = "Jade4",
                        ProductTypeId = 1,
                        Price = 50,
                        Score = 1
                    }, 
                    new Product()
                    {
                        Id = 5,
                        Name = "Jade5",
                        ProductTypeId = 1,
                        Price = 100,
                        Score = 1
                    },
                    new Product()
                    {
                        Id = 6,
                        Name = "Jade6",
                        ProductTypeId = 1,
                        Price = 50,
                        Score = 1
                    },
                    new Product()
                    {
                        Id = 7,
                        Name = "Jade7",
                        ProductTypeId = 1,
                        Price = 100,
                        Score = 1
                    },
                    new Product()
                    {
                        Id = 8,
                        Name = "Jade8",
                        ProductTypeId = 1,
                        Price = 50,
                        Score = 1
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
