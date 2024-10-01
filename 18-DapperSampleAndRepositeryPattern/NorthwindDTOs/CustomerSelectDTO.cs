using System;
namespace _18_DapperSampleAndRepositeryPattern.NorthwindDTOs
{

	/*Customer tablosundaki tüm alanlari selecet etmeyeceksek mesela
	 * CustomerId, CompanyName, ContactName,Country,City
	 * Database de bulunan sutun isimlerinin yazilisi ile asagıdaki proplar 
	 * ayni sekilde ifade edilmelidir.
	 */
	public class CustomerSelectDTO
	{
        public string customer_id { get; set; }
        public string company_name { get; set; }
        public string? contact_name { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
    }
}

