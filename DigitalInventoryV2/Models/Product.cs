using System;
using System.ComponentModel.DataAnnotations;

namespace DigitalInventoryV2.Models
{
	public class Product : BaseEntity
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		[Required]
		public string Code { get; set; }
		[Required]
		public string Name { get; set; }
		public string? Description { get; set; }
		public Category? Category {get;set;}
	}
}

