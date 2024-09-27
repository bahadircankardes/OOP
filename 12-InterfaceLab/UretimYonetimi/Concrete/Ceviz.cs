using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
    public class Ceviz : IKesilebilir
    {
        public void Kes()
        {
            Console.WriteLine($"{this.GetType().Name} Kesildi.");
        }
    }
}

