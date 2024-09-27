using _12_InterfaceLab.LokantaOrnegi.Abstract;
using _12_InterfaceLab.LokantaOrnegi.Concrete;

namespace _12_InterfaceLab;

class Program
{
    static void Main(string[] args)
    {
        //Borsa lokantasi yemek psisirecek
        //Kofte, Pilav, Cacik, Salata, TazeFasulye, Ispanak
        Kofte kofte = new Kofte();
        Pilav pilav = new Pilav();
        Cacik cacik = new Cacik();
        Salata salata = new Salata();
        TazeFasulye tazeFasulye = new TazeFasulye();
        Ispanak ispanak = new Ispanak();
        Kek kek = new Kek();

        
        
        List<IPisirilebilir> pisirilebilirs = new List<IPisirilebilir>();
        List<IYapilabilir> yapilabilirs = new List<IYapilabilir>();
        BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
        string secim = "";
        do
        {
            Console.WriteLine("Menü Secimi Yapiniz \n 1-Kofte \n 2-Pilav \n 3-Salata \n 0-Cıkıs");
            secim = Console.ReadLine();

            if (secim == "1")
            {
                pisirilebilirs.Add(kofte);
                
            }
            else if (secim =="2")
            {
                pisirilebilirs.Add(pilav);
                
            }
            else if (secim == "3")
            {
                yapilabilirs.Add(salata);
                
            }
            

        } while (secim!="0");

        borsaLokantasi.YemekPisir(pisirilebilirs);
        borsaLokantasi.YemekYap(yapilabilirs);




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
    }
}

