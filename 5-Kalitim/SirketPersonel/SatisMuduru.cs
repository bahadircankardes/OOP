using System;
namespace _5_Kalitim.SirketPersonel
{
	public class SatisMuduru : SatisPersoneli
	{
		public void EkipleToplantiYap()
		{

		}

		public SatisMuduru(string ad, string soyad) : base(ad, soyad)
        {
			Maas = Maas * 1.5;
		}
	}
}

