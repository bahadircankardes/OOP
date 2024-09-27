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

        List<IPisirilebilir> pisirileiblirs = new List<IPisirilebilir>();
        pisirileiblirs.Add(pilav);
        pisirileiblirs.Add(ispanak);
        pisirileiblirs.Add(tazeFasulye);

        List<IYapilabilir> yapilabilirs = new List<IYapilabilir>();
        yapilabilirs.Add(cacik);
        yapilabilirs.Add(salata);

        BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
        borsaLokantasi.YemekPisir(pisirileiblirs);
        //borsaLokantasi.YemekYap(yapilabilirs);
    }
}

