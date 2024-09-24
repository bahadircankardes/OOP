using System;
namespace _3_ClassLibrary.Okullar
{
	public class Ogretmen
	{
        public int Id { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public DateTime DogumYili { get; set; }
        public string Gsm { get; set; }
        public Brans Brans { get; set; }
        public int BransId { get; set; }
    }
}

