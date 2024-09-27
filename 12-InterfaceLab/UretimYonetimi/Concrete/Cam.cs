using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
    public class Cam : IBicilebilir
    {
        public void Bic()
        {
            Console.WriteLine($"{this.GetType().Name} Bicildi.");
        }
    }
}

