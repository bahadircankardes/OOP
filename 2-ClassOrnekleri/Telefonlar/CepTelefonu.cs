using System;
namespace _2_ClassOrnekleri.Telefonlar
{
	public class CepTelefonu
	{
        public string Marka { get; set; }
        public string Model { get; set; }
        public short UretimYili { get; set; }
        public short PilGucu { get; set; }
        public short RamKapasitesi { get; set; }
        public double Fiyat { get; set; }
        public bool HasCamera { get; set; }

    }
}

