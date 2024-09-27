using System;
using _12_InterfaceLab.LokantaOrnegi.Abstract;

namespace _12_InterfaceLab.LokantaOrnegi.Concrete
{
	public class Cacik:IYapilabilir
	{
        public void Yap()
        {
            Console.WriteLine($"{this.GetType().Name} Yapildi...");
        }
    }
}

