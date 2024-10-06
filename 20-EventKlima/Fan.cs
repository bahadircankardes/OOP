using System;
using static _20_EventKlima.Sensor;

namespace _20_EventKlima
{
	public class Fan
	{

        public void Calıs(int temperature)
        {
            if (temperature > 30)
            {
                Console.WriteLine($"Sicaklik: {temperature} derece. Fan yüksek ayarda calisiyor...");
            }
            else
            {
                Console.WriteLine($"Sicaklik: {temperature} derece, Sicaklik normal Fan durdu...");
            }
        }
    }
}

