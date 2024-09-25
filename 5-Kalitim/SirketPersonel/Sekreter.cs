using System;
namespace _5_Kalitim.SirketPersonel
{
	public class Sekreter : Personel
	{
        //Constructor class ismi ile ayni isimde olmak zorundadir.
        //Constructor'larin geri donus tipi yoktur.
        //Constructor'lar nesneden instance alindiginda calisir.

        //public Sekreter()
        //{
        //	Maas = Maas * 1.2;

        //}
        public Sekreter (string ad, string soyad) : base (ad, soyad)
        {
            Maas = Maas * 1.2;
        }


        public void TelefonlaraBakma()
		{
		}

		public void RandevuAyarla()
		{

		}
	}
}

