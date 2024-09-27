using System;
using _12_InterfaceLab.LokantaOrnegi.Abstract;

namespace _12_InterfaceLab.LokantaOrnegi.Concrete
{
	public class Ispanak:IPisirilebilir
	{
        public void pisir()
        {
            Console.WriteLine($"{this.GetType().Name} Pisti...");
        }
    }
}

