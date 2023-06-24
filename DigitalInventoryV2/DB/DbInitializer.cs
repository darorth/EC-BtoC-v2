using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalInventoryV2.Models;

namespace DigitalInventoryV2.DB
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context) { 
            var products = new Product[] {
                new Product() {
                    Code = "001",
                    Name = "Beer",
                },
                new Product() {
                    Code = "002",
                    Name = "Coke",
                },
                new Product() {
                    Code = "003",
                    Name = "Coca Cola",
                },
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }

    }
}