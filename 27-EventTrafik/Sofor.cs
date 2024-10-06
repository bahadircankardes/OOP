using System;
namespace _27_EventTrafik
{
    public delegate void TrafikHandler(int hiz, object sender);

    public class Sofor
	{
		public event TrafikHandler GazaBastim;
		public string AdSoyad { get; set; }
		public Sofor(string adsoyad)
		{
			AdSoyad = adsoyad;
		}

		public void GazaBas()
		{
			GazaBastim(140, this);
		}
	}
}

