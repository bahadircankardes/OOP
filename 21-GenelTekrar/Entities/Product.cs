using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace _21_GenelTekrar
{
    public class Product
	{
        [Dapper.Contrib.Extensions.Key]
		public int product_id { get; set; }
        public string product_name{ get; set; }
		public string? quantity_per_unit { get; set; }
		public decimal? unit_price { get; set; }
        public short? units_in_stock { get; set; }
        public short? units_on_order { get; set; }
        public int? reorder_level { get; set; }
        public int discontinued { get; set; }

        [ForeignKey("Shipper")]
        public int? SupplierId { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        //public List<OrderDetail>? OrderDetails { get; set; }

    }
}

