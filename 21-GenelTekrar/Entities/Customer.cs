using System;
using Dapper.Contrib.Extensions;

namespace _21_GenelTekrar
{ 
public class Customer
	{
		[Key]
		public string customer_id { get; set; }
		public string company_name { get; set; }
		public string? contact_name { get; set; }
		public string? contact_title { get; set; }
		public string? address { get; set; }
		public string? city { get; set; }
		public string? region { get; set; }
        public string? postalCode { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        public string? fax { get; set; }

        //public List<Order>? Orders { get; set; }//Bir musterinin birden cok
												//orderi olabilir bire çok iliski
												//Buna Navigation Property deniyor




    }
}

