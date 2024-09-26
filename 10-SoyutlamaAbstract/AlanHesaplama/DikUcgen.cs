using System;
namespace _10_SoyutlamaAbstract.AlanHesaplama
{
    public class DikUcgen : Sekil
    {
        public override int KisaKenar { get; set; }
        public override double AlanHesapla()
        {
            return (KisaKenar * UzunKenar)/2;
        }

        public override double CevreHesapla()
        {
            double hipotenüs = Math.Sqrt(Math.Pow(KisaKenar,2) + Math.Pow(UzunKenar,2));
            return hipotenüs + KisaKenar + UzunKenar;
        }

        public override string BilgileriGoster()
        {
            return $"Bu DikUcgenin Kisa Kenari = {KisaKenar}, Uzun Kenari = {UzunKenar}";
        }

        public override string ToString()
        {
            return "Dik Ucgenin:" + base.ToString();
        }
    }
}

