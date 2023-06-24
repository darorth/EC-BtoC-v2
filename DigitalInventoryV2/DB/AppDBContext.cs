using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalInventoryV2.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalInventoryV2.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cate1 = new Category { Id = 1, Code = "c001", Name = "Coke" };
            var cate2 = new Category { Id = 2, Code = "c001", Name = "Beer" };

            var pro1 = new Product { Id = 1, CategoryId = 1, Code = "p001", Name = "Coca Cola" };
            var pro2 = new Product { Id = 2, CategoryId = 1, Code = "p002", Name = "Sprite" };

            var pro3 = new Product { Id = 3, CategoryId = 2, Code = "p003", Name = "Angkor" };
            var pro4 = new Product { Id = 4, CategoryId = 2, Code = "p004", Name = "Anchor" };

            modelBuilder.Entity<Category>().HasData(cate1, cate2);
            modelBuilder.Entity<Product>().HasData(pro1, pro2, pro3, pro4);
            base.OnModelCreating(modelBuilder);
        }

    }
}