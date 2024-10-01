using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindSample.Concrete
{
	public class Product
	{
        [Key]
		public int ProductId { get; set; }
        public string ProductName{ get; set; }
		public string? QuantityPerUnit { get; set; }
		public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        [ForeignKey("Shipper")]
        public int? SupplierId { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }

    }
}

