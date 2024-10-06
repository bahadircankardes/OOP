namespace _31_ActionPredicateFucnDelegate;

class Program
{
    /*
      Action ve Action<T> delege türleri .Net framework 3.5 ile gelen önceden tanımlanmış 
     bir delege türüdür. Action<T> delege türleri Func<T> delegelerinin aksine hiçbir 
     değer döndürmeyen metodları temsil etmektedir. Action delege türü hiçbir parametre 
     almayan ve değer döndürmeyen metodları temsil eder. Adından da anlaşılacağı üzere 
     bir fonksiyonu değil bir eylemi(action) temsil etmektedirler.
      Action<T> delegeleri birden fazla parametre alabilecek metodları da temsil edebilecek şekilde tasarlanmıştır.
         Action
         Action <T>
         Action <T1,T2 >
         Action <T1,T2,T3>
         Action <T1,T2,…,TN>
     Her bir T, metodların alacağı parametrelerin tiplerini belirtmektedir.T Max 16 adettir.  T ,Max 16 adettir
     Func<T> gibi Action<T> kullandığımızda delege tanımlamamıza gerek kalmamaktadır.
      */

    //Action olmadan parametre almayan ve geri donusu olmayan metodun
    //delegate il tanimlanmasi

    public delegate void Islem();

    static void Main(string[] args)
    {
        //Islem islem = new Islem(MesajGosterMars);
        //islem += MesajGosterVenus;
        //islem.Invoke();
        #region Parametresiz Action yani generic olmayan

        //Action action = new Action(MesajGosterVenus);
        //action += MesajGosterMars;
        //action.Invoke();

        #endregion

        #region Generic Action Tanimlanmasi Action<aldigi_parametre_tipi>
        Action<int> action = new Action<int>(KareAl);
        action.Invoke(9);

        #endregion

        #region Lamda Expression Evrim Süreci

        //1.Anonim Metod ile Tanimlama

        Action<int> action1 = delegate (int sayi) { Console.WriteLine($"{sayi}'nin karesi : {sayi * sayi}'dir..."); };

        //2.Asama

        Action<int> action2 = (int sayi) => { Console.WriteLine($"{sayi}'nin karesi : {sayi * sayi}'dir..."); };

        //3. Asama

        Action<int> action3 = sayi => Console.WriteLine($"{sayi}'nin karesi : {sayi * sayi}'dir...");



        #endregion

        #region Predicate ve Lamda Expression
        // Predicate delegate System namesapace icerisinde olan ve geriye bool donen
        // icerisine generic olacak sekilde en fazla 16 adet parametre alan
        //  metodlarin imzasini temsil eden bir delegate dir.

        Predicate<int> predicate = new Predicate<int>(TekCift);
        Predicate<int> predicate1 = delegate (int sayi) { return sayi % 2 == 0; };
        Predicate<int> predicate2 =  (int sayi) => { return sayi % 2 == 0; };
        Predicate<int> predicate3 =  sayi =>  sayi % 2 == 0;

        List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9};

        var ciftsayilar = list.Where(sayi => sayi % 2 == 0).ToList();

        ciftsayilar.ForEach(sayi => Console.WriteLine(sayi)); //Foreach metodu Action<int> 
        //delegate alan bir yapisi vardir.


        #endregion


        Console.WriteLine("Hello, World!");

    }

    public static bool TekCift(int sayi)
    {
        return sayi % 2 == 0;
    }

    public static void KareAl(int sayi)
    {
        Console.WriteLine($"{sayi}'nin karesi : {sayi* sayi}'dir...");
    }

    public static void MesajGosterMars()
    {
        Console.WriteLine("Hello, Mars!");
    }


    public static void MesajGosterVenus()
    {
        Console.WriteLine("Hello, Venus!");
    }
}

