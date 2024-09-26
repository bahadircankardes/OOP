using System;
namespace _10_SoyutlamaAbstract.MuzikAletleri
{
	public class Piyano : MuzikAleti
	{
        public override string AkordYap()
        {
            return "Piyano Akord Edildi";
        }

        public override string Cal()
        {
            return "Piyano Caliniyor";
        }
    }
}

