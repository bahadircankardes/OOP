using System;

namespace NorthwindSample.Concrete
{
	public class Shipper
	{
		public string CompanyName { get; set; }

		public string Phone { get; set; }

		public List<Order> Orders { get; set; }
	}
}

