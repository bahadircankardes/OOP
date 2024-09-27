using System;
namespace _9_Polimorfizm.Hayvanlar
{
	public class Hayvan
	{
		public virtual void SesCikar()
		{
			Console.WriteLine("Hırrrrrrrr.........");
		}
		public virtual void HareketEt()
		{
			Console.WriteLine("Hareket ettti...");
		}
	}
}

