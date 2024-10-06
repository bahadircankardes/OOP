using System;
namespace _25_Event
{
	public class Araba
	{
        private readonly string _kod;

        public string MarkaModel { get; set; }

		public Araba(string kod)
		{
            this._kod = kod;
        }

		public void SinyalAl(string kod)
		{
			Console.WriteLine($"{MarkaModel} sinyal aldi..:{kod}");
			if (kod == _kod)
			{
				KapilariAc();
			}
		}

        private void KapilariAc()
        {
            Console.WriteLine($"{MarkaModel} aracin kapilari acildi.");
        }
    }
}

