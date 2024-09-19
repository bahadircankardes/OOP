using System;
namespace _2_ClassOrnekleri.Computer
{
	public class WissenComputer
	{
		public CPU Cpu { get; set; }
		public AnaKart AnaKart { get; set; }
		public List<Ram> Ram { get; set; } //Birden Fazla Ekran Kartı olabiliyorsa Liste
		public EkranKarti EkranKarti { get; set; }
		public Kasa Kasa { get; set; }
		public double Fiyat { get; set; }
	}
}

