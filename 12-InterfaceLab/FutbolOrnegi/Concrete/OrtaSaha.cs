using System;
using _12_InterfaceLab.FutbolOrnegi.Abstract;

namespace _12_InterfaceLab.FutbolOrnegi.Concrete
{
	public class OrtaSaha:BaseFutbolcu, IOrtaSaha
	{
        public void OyunKur()
        {
            Console.WriteLine($"{AdSoyad} Oyun Kuruluyor...");
        }

        public void PasTrafigiYap()
        {
            Console.WriteLine($"{AdSoyad} PasTrafigi Yapiliyor...");
        }
    }
}

