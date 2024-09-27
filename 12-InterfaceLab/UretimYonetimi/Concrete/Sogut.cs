using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
    public class Sogut : IDilimlenebilir
    {
        public void Dilimle()
        {
            Console.WriteLine($"{this.GetType().Name} Dilimlendi.");
        }
    }
}

