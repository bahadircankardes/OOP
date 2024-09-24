using System;
namespace _3_ClassLibrary.Okullar
{
	public class Sinif
	{
		public int Id { get; set; }
		public string SinifAdi { get; set; }
		public byte Kapasite { get; set; }
		public List<Ogrenci> Ogrenciler { get; set; }
	}
}