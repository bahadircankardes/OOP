using _12_InterfaceLab.FutbolOrnegi.Abstract;
using _12_InterfaceLab.FutbolOrnegi.Concrete;
using _12_InterfaceLab.LokantaOrnegi.Abstract;
using _12_InterfaceLab.LokantaOrnegi.Concrete;
using _12_InterfaceLab.UretimYonetimi.Concrete;

namespace _12_InterfaceLab;

class Program
{
    static void Main(string[] args)
    {
        #region Lokanta Ornegi

       
        ////Borsa lokantasi yemek psisirecek
        ////Kofte, Pilav, Cacik, Salata, TazeFasulye, Ispanak
        //Kofte kofte = new Kofte();
        //Pilav pilav = new Pilav();
        //Cacik cacik = new Cacik();
        //Salata salata = new Salata();
        //TazeFasulye tazeFasulye = new TazeFasulye();
        //Ispanak ispanak = new Ispanak();
        //Kek kek = new Kek();

        
        
        //List<IPisirilebilir> pisirilebilirs = new List<IPisirilebilir>();
        //List<IYapilabilir> yapilabilirs = new List<IYapilabilir>();
        //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
        //string secim = "";
        //do
        //{
        //    Console.WriteLine("Menü Secimi Yapiniz \n 1-Kofte \n 2-Pilav \n 3-Salata \n 0-Cıkıs");
        //    secim = Console.ReadLine();

        //    if (secim == "1")
        //    {
        //        pisirilebilirs.Add(kofte);
                
        //    }
        //    else if (secim =="2")
        //    {
        //        pisirilebilirs.Add(pilav);
                
        //    }
        //    else if (secim == "3")
        //    {
        //        yapilabilirs.Add(salata);
                
        //    }
            

        //} while (secim!="0");

        //borsaLokantasi.YemekPisir(pisirilebilirs);
        //borsaLokantasi.YemekYap(yapilabilirs);




        //List<IPisirilebilir> pisirileiblirs = new List<IPisirilebilir>();
        //pisirileiblirs.Add(pilav);
        //pisirileiblirs.Add(ispanak);
        //pisirileiblirs.Add(tazeFasulye);
        //pisirileiblirs.Add(kek);

        //List<IYapilabilir> yapilabilirs = new List<IYapilabilir>();
        //yapilabilirs.Add(cacik);
        //yapilabilirs.Add(salata);

        //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
        //borsaLokantasi.YemekPisir(pisirileiblirs);
        //borsaLokantasi.YemekYap(yapilabilirs);
        #endregion

        #region FutbolOrnegi
        Kaleci MertGunok = new Kaleci()
        {
            AdSoyad = "Mert Gunok",
            Mevki = FutbolOrnegi.Abstract.Mevki.Kaleci,
            DogumTarihi = new DateTime(1988, 5, 23),
            Millimi = true,
            Agresiflik = 99,
            Dayaniklilik = 100,
            Sutgucu = 56
        };

        Defans RonaldoZago = new Defans()
        {
            AdSoyad = "Ronaldo Zago",
            Mevki = FutbolOrnegi.Abstract.Mevki.Defans,
            DogumTarihi = new DateTime(1980, 5, 23),
            Millimi = true,
            Agresiflik = 99,
            Dayaniklilik = 99,
            Sutgucu = 78
        };

        OrtaSaha SergenYalcin = new OrtaSaha()
        {
            AdSoyad = "Ali Riza Sergen Yalcin",
            Mevki = FutbolOrnegi.Abstract.Mevki.OrtaSaha,
            DogumTarihi = new DateTime(1970, 5, 23),
            Millimi = true,
            Agresiflik = 99,
            Dayaniklilik = 50,
            Sutgucu = 78
        };

        Forvet MarioGomez = new Forvet()
        {
            AdSoyad = "Mario Gomez",
            Mevki = FutbolOrnegi.Abstract.Mevki.Forvet,
            DogumTarihi = new DateTime(1976, 4, 28),
            Millimi = true,
            Agresiflik = 78,
            Dayaniklilik = 89,
            Sutgucu = 100
        };

        List<BaseFutbolcu> futbolcular = new List<BaseFutbolcu>();
        futbolcular.Add(MarioGomez);
        futbolcular.Add(SergenYalcin);
        futbolcular.Add(MertGunok);
        futbolcular.Add(RonaldoZago);

        Takim Besiktas = new Takim(futbolcular);
        Console.WriteLine(Besiktas);


        #endregion

        #region UretimYonetimi
        Ceviz ceviz = new Ceviz();
        KestaneAgaci kestane = new KestaneAgaci();
        Sogut sogut = new Sogut();
        Cam cam = new Cam();

        Makina1 makina1 = new Makina1();//Keser
        Makina2 makina2 = new Makina2();//Dilimler
        Makina3 makina3 = new Makina3();//Bicer
        makina1.Isle(ceviz);
        makina1.Isle(kestane);

        makina2.Isle(kestane);
        makina2.Isle(sogut);

        makina3.Isle(cam);
        Console.ReadLine();



        #endregion
    }
}

