using System;
namespace _10_SoyutlamaAbstract.MuzikAletleri
{
	public class Flut : MuzikAleti
	{
        public override string AkordYap()
        {
            return "Flut Akord Edildi";
        }

        public override string Cal()
        {
            return "Flut Caliniyor";
        }
    }
}

