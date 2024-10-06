using System;
namespace _29_EventFiyatDustu
{
	public delegate void FiyatDustuDelegate();

	public class Urun
	{
		public event FiyatDustuDelegate FiyatDustuEvent;


        public string UrunAdi { get; private set; }
		private int _Fiyat;

		public int Fiyat
		{
			get { return _Fiyat; }
			set
			{
				if (value <= 60000)
				{
					FiyatDustuEvent();
				}
				_Fiyat = value;
			}

		

		}

        public Urun(string urunadi, int fiyat)
        {
			UrunAdi = urunadi;
			_Fiyat = fiyat;
        }





    }
}

