using System;
namespace _1_Giris
{
	public enum KasaTipi
	{
		Sedan = 1,
		Hatchback,
		Cabrio,
		StationVagon
	}

	public enum Vites
	{
		DuzVites,
		Otomatik,
		Triptonic
	}

	public enum Cekis
	{
		OndenCekis = 1,
		ArkadanItis,
		DortCeker
	}
	public class Otomobil
	{
		public string Marka { get; set; }

		public string Model { get; set; }

		public DateOnly CikisYili { get; set; }

		public KasaTipi KasaTipi { get; set; }

		public Vites Vites { get; set; }

		//public Cekis Cekis { get; set; }
	}
}

