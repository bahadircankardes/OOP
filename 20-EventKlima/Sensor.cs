using System;
namespace _20_EventKlima
{
	public class Sensor
	{
		public delegate void SensorDelegate(int temperature);
		public event SensorDelegate SicaklikDegisti;

		public void SicaklikDegistir(int temperature)
		{
			Console.WriteLine($"Sicaklik Degisti.. Sicaklik: {temperature} derece...");
			SicaklikDegisti(temperature);
		}

		
	}
}

