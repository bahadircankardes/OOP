using System;
using _12_InterfaceLab.FutbolOrnegi.Abstract;

namespace _12_InterfaceLab.FutbolOrnegi.Concrete
{
    public class Defans : BaseFutbolcu, IDefans
    {
        public void TopGecsinAdamGecmesin()
        {
            Console.WriteLine($"{AdSoyad} Adama daldi Topu Kapti...");
        }

        void IDefans.Defans()
        {
            Console.WriteLine($"{AdSoyad} Defans Yapiliyor...");
        }
    }
}

