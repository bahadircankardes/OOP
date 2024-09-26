using System;
namespace _10_SoyutlamaAbstract.MuzikAletleri
{
	public class Gitar : MuzikAleti
	{
        public override string AkordYap()
        {
             return "Gitar Akord Edildi";
        }

        public override string Cal()
        {
            return "Gitar Caliniyor";
        }
    }
}

