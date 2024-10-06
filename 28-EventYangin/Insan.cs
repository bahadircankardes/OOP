using System;
namespace _28_EventYangin
{
	public class Insan
	{
		public string AdSoyad { get; set; }
		public Insan(string adsoyad)
		{
			AdSoyad = adsoyad;
		}

		public void Kac(object sorun)
		{
			if (sorun is Alarm)
			{
				Console.WriteLine($"{AdSoyad} alarmdan dolayi kacti.");
			}
			else if (sorun is Sigara)
			{
				Console.WriteLine($"{AdSoyad} sigaradan dolayi kacti.");

			}
		}
        public void RahatsizOl(object rahatsizEden)
        {
			if (rahatsizEden is Alarm)
            {
				Console.WriteLine($"{AdSoyad} Alarm'dan dolayi rahatsiz oldu");
            }
            else if (rahatsizEden is Sigara)
            {
				Console.WriteLine($"{AdSoyad} Sigaradan 'dan dolayi öksürdü");
            }

        }
	}
}

