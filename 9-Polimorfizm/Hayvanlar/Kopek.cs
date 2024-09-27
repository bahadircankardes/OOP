using System;
namespace _9_Polimorfizm.Hayvanlar
{
	public class Kopek:Hayvan
	{
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav....");
        }
        public override void HareketEt()
        {
            Console.WriteLine("Zıplıyor Havlayarak....");
        }
    }
}

