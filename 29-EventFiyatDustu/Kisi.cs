using System;
namespace _29_EventFiyatDustu
{
	public class Kisi
	{
		public string AdSoyad { get; set; }

		public Kisi(string adSoyad)
		{
			AdSoyad = adSoyad;
		}

		public void HaberAl()
		{
			Console.WriteLine($"{AdSoyad} haber aldi.");
		}
	}
}

