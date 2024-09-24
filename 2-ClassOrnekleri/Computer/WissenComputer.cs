using System;
namespace _2_ClassOrnekleri.Computer
{
	public class WissenComputer
	{
		public CPU Cpu { get; set; } = new CPU(); // property init
		public AnaKart AnaKart { get; set; } = new AnaKart();
		public List<Ram> Ramler { get; set; } = new List<Ram>(); //Birden Fazla Ekran Kartı olabiliyorsa Liste
		public EkranKarti EkranKarti { get; set; } = new EkranKarti();
		public Kasa Kasa { get; set; } = new Kasa();
		public double Fiyat { get; set; }
	}
}

