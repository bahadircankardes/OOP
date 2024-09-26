using _10_SoyutlamaAbstract.AlanHesaplama;
using _10_SoyutlamaAbstract.MuzikAletleri;


namespace _10_SoyutlamaAbstract;

internal class Program
{
    static void Main(string[] args)
    {
        #region Sekil ile ilgili Abstraction Ornegı


        //DikUcgen dikUcgen = new DikUcgen() { KisaKenar = 3, UzunKenar = 4 };
        //Dikdortgen dikdortgen = new Dikdortgen { UzunKenar = 3, KisaKenar = 5 };
        //Kare kare = new Kare { UzunKenar = 4, KisaKenar = 4 };

        //Console.WriteLine($"Dikdortgenin Cevresi: {dikdortgen.CevreHesapla()}");
        //Console.WriteLine($"Dikdortgenin Alani: {dikdortgen.AlanHesapla()}");

        //Console.WriteLine($"Ucgenin Cevresi: {dikUcgen.CevreHesapla()}");
        //Console.WriteLine($"Ucgenin Alani: {dikUcgen.AlanHesapla()}");

        //Console.WriteLine($"Karenin Cevresi: {kare.CevreHesapla()}");
        //Console.WriteLine($"Karenin Alani: {kare.AlanHesapla()}");

        //Console.WriteLine($"Dikdotgenin Bilgileri: {dikdortgen.BilgileriGoster()}");
        //Console.WriteLine($"Ucgenin Bilgileri: {dikUcgen.BilgileriGoster()}");
        //Console.WriteLine($"Karenin Bilgileri: {kare.BilgileriGoster()}");

        //Console.WriteLine(dikdortgen);
        //Console.WriteLine(dikUcgen);
        //Console.WriteLine(kare);


        #endregion

        #region MuzikAletleri ile ilgili abstraction ornegi

        //Gitar gitar = new Gitar() { Marka = "QWERTY", Model = "SHORTY" };
        //Flut flut = new Flut() { Marka = "CASIO", Model = "QAZETY" };
        //Piyano piyano = new Piyano() { Marka = "GASTRO", Model = "POZTY" };
        //Darbuka darbuka = new Darbuka() {Marka = "FERKY" };

        //Console.WriteLine(gitar.AkordYap());
        //Console.WriteLine(gitar.Cal());

        //Console.WriteLine(flut.AkordYap());
        //Console.WriteLine(flut.Cal());

        //Console.WriteLine(piyano.AkordYap());
        //Console.WriteLine(piyano.Cal());

        //Muzisyen HalukLevent = new Muzisyen() { AdSoyad = "Haluk Levent"};
        //List<MuzikAleti> muzikAletis = new List<MuzikAleti>();
        //muzikAletis.Add(gitar);
        //muzikAletis.Add(flut);
        //muzikAletis.Add(piyano);
        ////muzikAletis.Add(darbuka);//Darbuka eklemeye kakinca hata verecektir.
        ////Muzikaleti base inden kalitim almadıgı icin eklenemez. 
        //HalukLevent.MuzikAletleriCal(muzikAletis);
        #endregion
    }
}

