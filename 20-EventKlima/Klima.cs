using System;
using static _20_EventKlima.Sensor;

namespace _20_EventKlima
{
	public class Klima
	{

        public void Calıs(int temperature)
		{
			if (temperature > 25)
			{
				Console.WriteLine($"Sicaklik: {temperature} derece. Klima yüksek ayarda calisiyor...");
			}
			else
			{
				Console.WriteLine($"Sicaklik: {temperature} derece, Sicaklik normal klima kapali...");
			}
		}
	}
}

