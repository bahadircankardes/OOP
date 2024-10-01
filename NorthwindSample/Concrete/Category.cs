using System;
namespace NorthwindSample.Concrete
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string? Description { get; set; }//Nullable olması gerekkiyor o yüzden '?' koyduk
		public Byte[]? Picture { get; set; }


	}
}

