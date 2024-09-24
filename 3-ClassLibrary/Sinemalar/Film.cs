using System;
namespace _3_ClassLibrary.Sinemalar
{
	public class Film
	{
		public int Id { get; set; }
		public string FilmAdi { get; set; }
		public string Aciklama { get; set; }
		public List<Kategori> Kategoriler { get; set; }
	}
}

