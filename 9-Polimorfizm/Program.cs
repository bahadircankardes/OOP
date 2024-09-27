using _9_Polimorfizm.CepTelefonlari;
using _9_Polimorfizm.Hayvanlar;

namespace _9_Polimorfizm;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia();
        Samsung samsung = new Samsung();
        Iphone iphone = new Iphone();

        nokia.CallSound();
        iphone.CallSound();
        samsung.CallSound();

        Hayvan hayvan = new Hayvan();
        hayvan.SesCikar();
        hayvan.HareketEt();

        Kedi kedi = new Kedi();
        kedi.SesCikar();
        kedi.HareketEt();

        Kopek kopek = new Kopek();
        kopek.SesCikar();
        kopek.HareketEt();

        Kus kus = new Kus();
        kus.SesCikar();
        kus.HareketEt();

    }
}

