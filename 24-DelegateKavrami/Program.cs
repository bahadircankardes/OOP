namespace _24_DelegateKavrami;

class Program
{
    //Delegate
    //Metot Tipi deklerasyonunu sağlar.
    /*
     Örnek delege:

    <erişim belirleyici> delegate <geri dönüş tipi> <delege adı>(<parametreler>)

    public delegate int Hesaplayici(int a,int b);

    Örnek delegemizin tanımlanış biçimindeki ifadelerin ne anlama geldiklerini ise 
    sırayla şu şeklide ifade edebiliriz.

    Public: delegenin erişim belirleyicisi. Public veya private olabilir.

    int: metodun geri dönüş tipi. Yani geri dönüş tipi int olan metodları temsil ediyor.

    Hesaplayici: delegenin adı.

    int a, int b: delegemiz, int tipinde iki adet parametre alan metodları temsil ediyor.

    Yukarıda tanımlanan Hesaplayici adlı delege, int tipinde değerler döndüren ve int tipinde iki adet 
    parametre alan metodları temsil etmektedir.
    *
    */

    public delegate int Hesaplayici(int x, int y);

    public delegate void LoggerDelegate(string msg);

    static void Main(string[] args)
    {
        #region Giriş
        //Hesaplayici hesaplayici = new Hesaplayici(Topla);
        ////Delegeye baska bir metod eklemeye yarar. Metod imzaları ayni olmali
        ////Metod imzalari derken geri donus degeri ve parametreler.
        //hesaplayici = hesaplayici + Carp;
        //hesaplayici += Bol;
        //var sonuc = hesaplayici.Invoke(15, 3);
        //foreach (var item in hesaplayici.GetInvocationList())
        //{
        //    Console.WriteLine(item.DynamicInvoke(15, 3));
        //}
        ////Test(hesaplayici);
        #endregion

        #region Logger Ornegi

        LoggerDelegate loggerDelegate = new LoggerDelegate(FileLogger);
        loggerDelegate += SmsLogger;
        loggerDelegate += MailLogger;
        loggerDelegate += DbLogLogger;

        try
        {
            int a = 3, b = 0;
            int sonuc = a / b;

        }
        catch (Exception ex)
        {
            loggerDelegate.Invoke(ex.Message);
        }





        #endregion




    }
    //Amacim bir exception yakaladigimda hem dosyaya hem database
    //kayit yapsin hem de mail ve sms atsin.
    static void FileLogger(string msg)
    {
        Console.WriteLine("File Logger:" + msg);
    }

    static void DbLogLogger(string msg)
    {
        Console.WriteLine("Db Logger:" + msg);
    }

    static void MailLogger(string msg)
    {
        Console.WriteLine("Mail Logger:" + msg);
    }

    static void SmsLogger(string msg)
    {
        Console.WriteLine("Sms Logger:" + msg);
    }


    static void Test(Delegate del)
    {
        Console.WriteLine(del.DynamicInvoke(3, 5));
    }

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static int Carp(int a, int b)
    {
        return a * b;
    }

    static int Bol(int a, int b)
    {
        return a / b;
    }
}

