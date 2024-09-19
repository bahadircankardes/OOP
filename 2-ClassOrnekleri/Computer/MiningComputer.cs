using System;
namespace _2_ClassOrnekleri.Computer
{
	public class MiningComputer
	{
        public CPU Cpu { get; set; }
        public AnaKart AnaKart { get; set; }
        public List<Ram> Ramler { get; set; }
        public List<EkranKarti> EkranKartlari { get; set; }
        public Kasa Kasa { get; set; }
    }
}

