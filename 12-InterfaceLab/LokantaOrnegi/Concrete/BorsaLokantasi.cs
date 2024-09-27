using System;
using _12_InterfaceLab.LokantaOrnegi.Abstract;

namespace _12_InterfaceLab.LokantaOrnegi.Concrete
{
	public class BorsaLokantasi
	{
		public void YemekPisir(List<IPisirilebilir> pisirilebilirs)
		{
			foreach (var item in pisirilebilirs)
			{
				item.pisir();
			}
		}

		public void YemekYap(List<IYapilabilir> yapilabilirs)
		{
			foreach (var item in yapilabilirs)
			{
				item.Yap();
			}
		}
	}
}

