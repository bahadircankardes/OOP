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

		public double Maas { get; set; }
		public int DepartmanId { get; set; }
		public Departman Departman { get; set; }
		public bool IseZamanindaGel ()
		{
			return true;
		}



	}
}

