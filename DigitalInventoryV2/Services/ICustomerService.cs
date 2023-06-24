using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalInventoryV2.Models;

namespace DigitalInventoryV2.Services
{
    public interface ICustomerService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Update(T entity);
        Task<T> Create(T entity);
        Task<T> Delete(T entity);
        Task<bool> IsExist(T entity);
    }
}