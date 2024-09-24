using System;
namespace _5_Kalitim.Computer
{
    public class OyuncuBilgisayari : BaseType
    {
        public CPU Cpu { get; set; }
        public AnaKart AnaKart { get; set; }
        public List<Ram> Ramler { get; set; } = new List<Ram>(); //Birden Fazla Ekran Kartı olabiliyorsa Liste
        public EkranKarti EkranKarti { get; set; }
        public Kasa Kasa { get; set; }
    }
}

