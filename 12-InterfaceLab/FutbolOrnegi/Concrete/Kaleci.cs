using System;
using _12_InterfaceLab.FutbolOrnegi.Abstract;

namespace _12_InterfaceLab.FutbolOrnegi.Concrete
{
	public class Kaleci:BaseFutbolcu,IKaleci
	{
        public void DegajYap()
        {
            Console.WriteLine($"{AdSoyad} Degaj Yapiyorr...");

        }

        public void PenaltiKurtar()
        {
            Console.WriteLine($"{AdSoyad} Penalti Kurtarildi....");
        }

        public void TopuElleYakala()
        {
            Console.WriteLine($"{AdSoyad} Top Elle Yakalandi....");
        }
    }
}

