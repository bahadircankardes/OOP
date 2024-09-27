using System;
namespace _12_InterfaceLab.FutbolOrnegi.Abstract
{
	public enum Mevki:byte
	{
		Kaleci=1,
		Defans,
		OrtaSaha,
		Forvet
	}
	public class BaseFutbolcu : IFutbolcu
    {
        public Mevki Mevki { get; set; }
		public string AdSoyad { get; set; }
		public DateTime DogumTarihi { get; set; }
		public bool Millimi { get; set; }
		public int Sutgucu { get; set; }
		public int Agresiflik { get; set; }
		public int Dayaniklilik { get; set; }

        public void Kos()
        {
			Console.WriteLine($"{AdSoyad} Kosuyor....");
		}

        public void PasAt()
        {
            Console.WriteLine($"{AdSoyad} Pas atiyor....");
        }

        public void PresYap()
        {
            Console.WriteLine($"{AdSoyad} Press Yapiyorrr....");
        }

        public void SutCek()
        {
            Console.WriteLine($"{AdSoyad} Sut Cekiyorrrr....");
        }

        public override string ToString()
        {
            return $"\n{AdSoyad} \n Dogum Tarihi: {DogumTarihi} \n Mevki: {Mevki} \n Sut Gucu: {Sutgucu} \n Agresiflik: {Agresiflik} \n Dayaniklilik: {Dayaniklilik} Milli mi? {Millimi}";
        }
    }
}

