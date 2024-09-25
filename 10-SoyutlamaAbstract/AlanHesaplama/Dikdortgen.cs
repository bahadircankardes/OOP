using System;
namespace _10_SoyutlamaAbstract.AlanHesaplama
{
    public class Dikdortgen : Sekil
    {
        public override double AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }

        public override double CevreHesapla()
        {
            return (UzunKenar + KisaKenar)*2;
        }

        public override string BilgileriGoster()
        {
            return $"Bu Dikdorgenin Kisa Kenari = {KisaKenar}, Uzun Kenari = {UzunKenar}";

        }
    }
}

