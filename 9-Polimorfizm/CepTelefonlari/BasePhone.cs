using System;
namespace _9_Polimorfizm.CepTelefonlari
{
	public class BasePhone
	{
		public string Marka { get; set; }
		public string Model { get; set; }

		public virtual void CallSound()
		{
			Console.WriteLine("Telefon Caliyor....");
		}
	}
}

