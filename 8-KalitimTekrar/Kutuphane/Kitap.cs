using System;
namespace _8_KalitimTekrar.Kutuphane
{
	public class Kitap
	{
		public int Id { get; set; }
		public string KitapAdi { get; set; }
		public Yazar Yazar { get; set; }
		public short SayfaSayisi { get; set; }
		public Kategori Kategori { get; set; }

	}
}

