using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalInventoryV2.DB;
using DigitalInventoryV2.Models;
using DigitalInventoryV2.Services;
using Microsoft.EntityFrameworkCore;

namespace DigitalInventoryV2.Repositories
{
    public class ProductRepository : ICustomerService<Product>
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Create(Product entity)
        {
            // if (entity == null)
            // {
            //     throw new ArgumentNullException("entity");
            // }

            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public Task<Product> Update(Product p)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Delete(Product p)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExist(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}