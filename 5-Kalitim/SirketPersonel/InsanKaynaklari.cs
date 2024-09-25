using System;
namespace _5_Kalitim.SirketPersonel
{
	public class InsanKaynaklari : Personel
	{
		public InsanKaynaklari(string ad, string soyad) : base(ad, soyad)
		{

		}


        public bool IseAlimGorüsmesiYap(Kisi kisi)
		{
			if (kisi.TcNo != null)
			{
				return true;
			}

			else
			{
				return false;
			}
		}

		public void PerformansDegerlendir()
		{

		}

        public void PersoneleUyariBildir(Personel personel)
        {

        }

    }
}

