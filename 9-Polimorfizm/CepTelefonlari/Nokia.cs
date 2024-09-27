using System;
namespace _9_Polimorfizm.CepTelefonlari
{
	public class Nokia:BasePhone
	{
        public override void CallSound()
        {
            Console.WriteLine("Nokia sesi caliniyor....");
        }
    }
}

