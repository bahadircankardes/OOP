using System;
namespace _27_EventTrafik
{
	public class Polis
	{
		public string AdSoyad { get; set; }
        LoggerDelegate _loggerDelegate;
		
		public Polis(string adsoyad)
		{
            _loggerDelegate = new LoggerDelegate(SmsGonder);
            _loggerDelegate += MailGonder;
            _loggerDelegate += TebligatGonder;

            AdSoyad = adsoyad;
		}

		public void HizKontrolEt(int hiz, object tetikleyen)
		{
			if (tetikleyen is Araba && hiz > 120)
			{
				Araba otomobil = tetikleyen as Araba;
				otomobil.ArabaCalisiyormu = false;
				string msg = $"{otomobil.Plaka} li {otomobil.MarkaModel} aracin {otomobil.Sofor.AdSoyad} li soforune \n {hiz} km/sa hizla gittiginden dolayi {this.AdSoyad} isimli polis tarafindan ceza kesilmiştir. " ;
                _loggerDelegate.Invoke(msg);
			}

			else if (tetikleyen is Kamyon && hiz > 90)
            {
                Kamyon kamyon = tetikleyen as Kamyon;
                kamyon.ArabaCalisiyormu = false;
                string msg = $"{kamyon.Plaka} li {kamyon.MarkaModel} aracin {kamyon.Sofor.AdSoyad} li soforune \n {hiz} km/sa hizla gittiginden dolayi {this.AdSoyad} isimli polis tarafindan ceza kesilmiştir. ";
                _loggerDelegate.Invoke(msg);

            }
        }
        public void SmsGonder(string msg)
        {
            Console.WriteLine($"Sms Gonderildi: {msg}");
        }

        public void MailGonder(string msg)
        {
            Console.WriteLine($"Mail Gonderildi: {msg}");
        }

        public void TebligatGonder(string msg)
        {
            Console.WriteLine($"Tebligat Gonderildi: {msg}");
        }
    }
    
}

