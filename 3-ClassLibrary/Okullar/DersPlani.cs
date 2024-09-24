using System;
namespace _3_ClassLibrary.Okullar
{
	public class DersPlani
	{
		public int Id { get; set; }
		public int OgretmenId { get; set; }
		public int SinifId { get; set; }
		public DateOnly Tarih { get; set; }
		public TimeOnly Saat { get; set; }


	}
}

