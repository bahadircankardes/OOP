using System;
namespace _3_ClassLibrary.Okullar
{
	public class Ogrenci
	{
        public int SinifId { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public DateTime DogumYili { get; set; }
        public string Gsm { get; set; }
        public Sinif Sinif { get; set; }

    }
}

