using System;
using _12_InterfaceLab.LokantaOrnegi.Abstract;

namespace _12_InterfaceLab.LokantaOrnegi.Concrete
{
	public class Salata:IYapilabilir
	{
        public void Yap()
        {
            Console.WriteLine($"{this.GetType().Name} Yapildi...");
        }
    }
}

