using _10_SoyutlamaAbstract.AlanHesaplama;

namespace _10_SoyutlamaAbstract;

internal class Program
{
    static void Main(string[] args)
    {
        DikUcgen dikUcgen = new DikUcgen() { KisaKenar = 3, UzunKenar = 4 };
        Dikdortgen dikdortgen = new Dikdortgen { UzunKenar = 3, KisaKenar = 5 };
        Kare kare = new Kare { UzunKenar = 4, KisaKenar= 4};

        Console.WriteLine($"Dikdortgenin Cevresi: {dikdortgen.CevreHesapla()}");
        Console.WriteLine($"Dikdortgenin Alani: {dikdortgen.AlanHesapla()}");

        Console.WriteLine($"Ucgenin Cevresi: {dikUcgen.CevreHesapla()}");
        Console.WriteLine($"Ucgenin Alani: {dikUcgen.AlanHesapla()}");

        Console.WriteLine($"Karenin Cevresi: {kare.CevreHesapla()}");
        Console.WriteLine($"Karenin Alani: {kare.AlanHesapla()}");

        Console.WriteLine($"Dikdotgenin Bilgileri: {dikdortgen.BilgileriGoster()}");
        Console.WriteLine($"Ucgenin Bilgileri: {dikUcgen.BilgileriGoster()}");
        Console.WriteLine($"Karenin Bilgileri: {kare.BilgileriGoster()}");

    }
}

