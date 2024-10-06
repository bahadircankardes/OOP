using System;
namespace _26_EventBomba
{
	public delegate void BombaPatlat(); 

	public class Telefon
	{
		public event BombaPatlat KelimeKullanildiEvent; 

		public void Gorusme()
		{
			Console.WriteLine("Alo ..");
			string kelime = Console.ReadLine();
			if (kelime.ToLower() == "kirmizi")
			{
				KelimeKullanildiEvent();
			}
			else
			{
				Gorusme();

            }
		}

	}
}

