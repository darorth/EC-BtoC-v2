using System;
using System.ComponentModel.DataAnnotations;

namespace DigitalInventoryV2.Models
{
    public class Category : BaseEntity
    {
        public int Id { get; set; }
		[Required]
        public string Code { get; set; }
		[Required]
        public string Name { get; set; }
        public string? Remark { get; set; }
        public ICollection<Product> Products { get; } = new List<Product>(); // Collection navigation containing dependents

    }
}

