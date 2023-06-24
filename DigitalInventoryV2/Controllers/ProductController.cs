using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalInventoryV2.Models;
using DigitalInventoryV2.DB;
using DigitalInventoryV2.Repositories;
using DigitalInventoryV2.Services;

namespace DigitalInventoryV2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : BaseApiController
    {
        private readonly IProduct _product;
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            // _product = product;
            _context = context;
        }

        // [HttpGet]
        // public Task<IEnumerable<Product>> GetAll()
        // {
        //     return _product.GetAll();

        // }

        [HttpGet("{id}")]
        [ActionName("GetProduct")]
        public async Task<Product> GetProduct(int? id)
        {
            // return _product.Get(id);
            return await _context.Products.FindAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(product.Id);

        }

    }
}