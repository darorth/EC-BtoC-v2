using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalInventoryV2.Models;

namespace DigitalInventoryV2.Services
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Update(Product p);
        Task<Product> Get(int id);
        Task<Product> Create(Product p);
        Task<Product> Delete(Product p);
        Task<bool> IsExist(Product p);
    }
}