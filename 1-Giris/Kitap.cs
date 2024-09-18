using System;
namespace _1_Giris
{
	public enum Dili
	{
		Turkce=1,
		Ingılızce,
		Fransizca,
		Almanca,
		Arapca,
		Farsca
	}
	public enum HamurTipi
	{
		BirirnciHamur=1,
		İkinciHamur,
		UcuncuHamur
	}
	public enum BaskiSayisi
	{
		BirinciBasim=1,
		İkinciBasim,
		UcuncuBasim,
		DorduncuBasim,
		BesinciBasim
	}
	public class Kitap
	{
		public string KitapAdi { get; set; }
		public string Yazar { get; set; }
        public string Cevirmen { get; set; }
        public string YayinEvi { get; set; }
		public HamurTipi HamurTipi { get; set; }
        public string SayfaSayisi { get; set; }
        public string Ebat { get; set; }
		public string IlkBaskiYili { get; set; }
		public BaskiSayisi BaskiSayisi { get; set; }
		public Dili Dili { get; set; }
		public string Barkod { get; set; }





	}
}

