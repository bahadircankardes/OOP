using System;
namespace _5_Kalitim.SirketPersonel
{

	public class Departman
	{
		public int Id { get; set; }
		public string DepartmanAdi { get; set; }
		public List<Personel> Personeller { get; set; }

	}
	public class Personel : Kisi
	{

		public double Maas { get; set; } = 17002;
		public int DepartmanId { get; set; }
		public Departman Departman { get; set; }

		//public Personel() //Constructor
		//{

		//}

		//Bir personel olusturuldugunda (instance alindiginda)
		//mutlakaa ozluk bılgılerı gırılecek

		public Personel(string ad, string soyad):base(ad, soyad)
		{
			//Buraya pesonel ileilgili baska kodlar yazilabilir.
		}

		public bool IseZamanindaGel ()
		{
			return true;
		}



	}
}

