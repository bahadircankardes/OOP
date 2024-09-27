using System;
using _12_InterfaceLab.LokantaOrnegi.Abstract;

namespace _12_InterfaceLab.LokantaOrnegi.Concrete
{
	public class Pilav:IPisirilebilir
	{
        public void pisir()
        {
            Console.WriteLine($"{this.GetType().Name} Pisti...");
        }
    }
}

