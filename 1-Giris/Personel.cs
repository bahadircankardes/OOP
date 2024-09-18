using System;
namespace _1_Giris
{
	public class Personel
	{
		string _tcno;
		// Kontrollü veri alıp verdiğim property
		public string TcNo
		{
			get
			{
				if (!string.IsNullOrEmpty(_tcno))
				{
					return _tcno.Substring(7);
				}

				else
				{
					return "";
				}
				
			}

			set
			{
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
				{
					_tcno = value;
				}
			}

		}

		//Bos Property tanimlari
		// Property isimleri verirken Pascal Case kullanilir.

		public string Ad { get; set; }

		public string Soyad { get; set; }

		public DateOnly DogumTarihi { get; set; }

		public bool Cinsiyet { get; set; }

		public double Maas { get; set; }

		public string Adres { get; set; }



	}
}

