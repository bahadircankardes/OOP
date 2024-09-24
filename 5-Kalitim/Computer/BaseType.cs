using System;
namespace _5_Kalitim.Computer
{
	public abstract class BaseType : BaseId
        // abstract yazilinca bu klastan new ile
        // instance alınamaz. abstract siniflardan instance alinamaz.
        // Diger siniflara kalitim vermek icin kullanilir.
	{
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

    }
}

