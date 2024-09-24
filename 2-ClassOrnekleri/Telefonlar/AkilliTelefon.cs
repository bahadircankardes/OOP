using System;
namespace _2_ClassOrnekleri.Telefonlar
{
	public enum IsletimSistemi
	{
		IOS=1,
		Android,
		HarmonyOs
	}

	public class AkilliTelefon
	{
        public string Marka { get; set; }
        public string Model { get; set; }
        public short UretimYili { get; set; }
        public short PilGucu { get; set; }
        public short RamKapasitesi { get; set; }
        public double Fiyat { get; set; }
        public bool HasCamera { get; set; }
		public bool FaceId { get; set; }
		public IsletimSistemi IsletimSistemi { get; set; }
		public object MyProperty { get; set; }


	}
}

