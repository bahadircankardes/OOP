using System;
using _12_InsanKaynaklari.Concrete;

namespace _12_InsanKaynaklari.Abstract
{
	public enum Askerlik
	{
		Yapti=1,
		Yapmadi,
		Muaf

	}
	public abstract class BaseBasvuru
	{

		public Departman departman { get; set; }
        public Kisi Kisi { get; set; }

		public bool UniversiteMezunuMu { get; set; }

		public bool EhliyetiVarMı { get; set; }

		public bool UzaktanCalisabilirmi { get; set; }
		public Askerlik Askerlik { get; set; }




	}
}

