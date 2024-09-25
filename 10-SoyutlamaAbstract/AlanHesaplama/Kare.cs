using System;
namespace _10_SoyutlamaAbstract.AlanHesaplama
{
	public class Kare : Sekil
	{
        public override double CevreHesapla()
        {
            return 4 * UzunKenar;
        }

        public override double AlanHesapla()
        {
            return Math.Pow(UzunKenar, 2);
        }

        public override string BilgileriGoster()
        {
            return $"Bu Karenin Kisa Kenari = {KisaKenar}, Uzun Kenari = {UzunKenar}";

        }
    }
}

