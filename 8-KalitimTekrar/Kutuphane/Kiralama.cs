using System;
namespace _8_KalitimTekrar.Kutuphane
{
	public class Kiralama
	{
		public Uye Uye { get; set; }
		public List<Kitap> Kitaplar { get; set; }
		public DateTime AlmaTarihi { get; set; }
		public DateTime VerilenSure { get; set; }
		public Personel Personel { get; set; }
	}
}

