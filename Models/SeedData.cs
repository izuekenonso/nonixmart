using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using nonixmart.Data;
using System;
using System.Linq;

namespace nonixmart.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new nonixmartContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<nonixmartContext>>()))
            {
                // Look for any products.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Title = "Plate Rack",
                        ExpiryDate = DateTime.Parse("2021-2-12"),
                        Category = "Kitchen Utensils",
                        Price = 500.00M,
                        Quantity = 6
                    },

                    new Product
                    {
                        Title = "Big Pack Sunlight",
                        ExpiryDate = DateTime.Parse("2021-3-13"),
                        Category = "Detergent",
                        Price = 100.00M,
                        Quantity = 5
                    },

                    new Product
                    {
                        Title = "Electric kettle",
                        ExpiryDate = DateTime.Parse("2020-12-12"),
                        Category = "Kitchen Utensils",
                        Price = 850.00M,
                        Quantity = 11
                    }
                );
                context.SaveChanges();
            }
        }
    }
}