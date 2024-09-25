using System;
namespace _5_Kalitim.SirketPersonel
{
	public class SatisPersoneli : Personel
	{
		public SatisPersoneli(string ad, string soyad) : base(ad, soyad)
        {
			Maas = Maas * 1.5;
		}

		public void MusterilerleGorus()
		{
			
		}

        public void MusterileriAra()
        {

        }
    }

}

