namespace _29_EventFiyatDustu;

class Program
{
    static void Main(string[] args)
    {
        Kisi ali = new Kisi("Ali");
        Kisi veli = new Kisi("Veli");
        Kisi ayse = new Kisi("Ayse");
        Kisi fatma = new Kisi("Fatma");
        Kisi hasan = new Kisi("Hasan");

        Urun iphone50 = new Urun("Iphone 50", 100000);

        iphone50.FiyatDustuEvent += ali.HaberAl;
        iphone50.FiyatDustuEvent += veli.HaberAl;
        iphone50.FiyatDustuEvent += ayse.HaberAl;
        iphone50.FiyatDustuEvent += fatma.HaberAl;
        iphone50.FiyatDustuEvent += hasan.HaberAl;

        iphone50.Fiyat = 50000;

    }
}

 