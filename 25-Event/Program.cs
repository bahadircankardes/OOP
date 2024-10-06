namespace _25_Event;

class Program
{
    //Bir olayın gerçekleştiğini belirten bir tetikleyicidir.
    //Event tetiklendiğinde event için önceden atanmış olan metotlar çalışır.
    //Gövdesiz metota benzer. Lakin handler süreci farklıdır.
    //Metot ne yapacağını bildiğimiz ve ne zaman çalışacağını bildirimiz durumlarda kullanılır

    //Eventte en az iki obje vardır. bir taraf ne yapılacağını bilir ama ne zaman yapılacağını bilmez
    //Diğer taraf ne zaman yapılacağını bilir ama ne yapılacağını bilmez.
    static void Main(string[] args)
    {
        Kumanda kumanda = new Kumanda("qwerty");
        Kumanda kumanda1 = new Kumanda("qaz");
        Kumanda kumanda2 = new Kumanda("wsx");
        Kumanda kumanda3 = new Kumanda("edc");

        Araba araba = new Araba("edc") { MarkaModel="BMV 3.20"};
        kumanda.KumandaEvent += araba.SinyalAl;
        kumanda1.KumandaEvent += araba.SinyalAl;
        kumanda2.KumandaEvent += araba.SinyalAl;
        kumanda3.KumandaEvent += araba.SinyalAl;

        kumanda.TusaBas();
        kumanda1.TusaBas();
        kumanda2.TusaBas();
        kumanda3.TusaBas();


        Console.WriteLine("Hello, World!");
    }
}

