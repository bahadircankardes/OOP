using System;
namespace _2_ClassOrnekleri.Computer
{
    public class OyuncuBilgisayari
    {
        public CPU Cpu { get; set; }
        public AnaKart AnaKart { get; set; }
        public List<Ram> Ramler { get; set; } = new List<Ram>(); //Birden Fazla Ekran Kartı olabiliyorsa Liste
        public EkranKarti EkranKarti { get; set; }
        public Kasa Kasa { get; set; }
        public double Fiyat { get; set; }
    }
}

