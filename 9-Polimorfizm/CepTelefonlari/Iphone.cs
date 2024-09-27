using System;
namespace _9_Polimorfizm.CepTelefonlari
{
	public class Iphone : BasePhone
	{
        public override void CallSound()
        {
            Console.WriteLine("Iphone sesi caliniyor....");
        }
    }
}

