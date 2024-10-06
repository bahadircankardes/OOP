using System;
namespace _27_EventTrafik
{
	public class Kamyon
	{
        public event TrafikHandler HareketEdiyorum;
        private int _hiz;
        public Sofor Sofor { get; set; }
        public string MarkaModel { get; set; }
        public string Plaka { get; set; }
        public bool ArabaCalisiyormu { get; set; }

        public Kamyon(Sofor sofor, string markamodel, string plaka)
        {
            Sofor = sofor;
            MarkaModel = markamodel;
            Plaka = plaka;

        }

        public void Calis(int gazOrani, object gazabasan)
        {
            ArabaCalisiyormu = true;
            while (ArabaCalisiyormu)
            {
                _hiz += gazOrani;
                Console.WriteLine($"{Plaka} li {MarkaModel} arac {_hiz} km/sa hizla gidiyor");
                HareketEdiyorum(_hiz, this);
            }
        }
    }
}

