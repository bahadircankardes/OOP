using System;
namespace _5_Kalitim.Computer
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

