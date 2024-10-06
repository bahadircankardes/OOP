using System;
namespace _25_Event
{
	public delegate void KumandaDelege(string kod);

	public class Kumanda
	{
		public event KumandaDelege KumandaEvent;

		private string _kod;

		public Kumanda(string kod)
		{
			_kod = kod;
		}

		public void TusaBas()
		{
			Console.WriteLine("Tusa Basildi....");
			KumandaEvent(_kod);
		}
	}
}

