using System;
using _12_InterfaceLab.FutbolOrnegi.Abstract;

namespace _12_InterfaceLab.FutbolOrnegi.Concrete
{
    public class Forvet : BaseFutbolcu, IForvet
    {
        public void GolAt()
        {
            Console.WriteLine($"{AdSoyad} Goooooooooool...");
        }

        public void PenaltiAt()
        {
            Console.WriteLine($"{AdSoyad} Penalti Atiliyor ve Goooooll...");
        }
    }
}

