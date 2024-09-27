using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
	public class KestaneAgaci:IKesilebilir, IDilimlenebilir
	{
        public void Dilimle()
        {
            Console.WriteLine($"{this.GetType().Name} Dilimlendi.");
        }

        public void Kes()
        {
            Console.WriteLine($"{this.GetType().Name} Kesildi.");
        }
    }
}

