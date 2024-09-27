using System;
namespace _9_Polimorfizm.Hayvanlar
{
	public class Kedi:Hayvan
	{
        public override void SesCikar()
        {
            Console.WriteLine("Miyavvv....");
        }
        public override void HareketEt()
        {
            Console.WriteLine("Kosuyor Miyavvv....");
        }
    }
}

