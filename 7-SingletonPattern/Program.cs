namespace _7_SingletonPattern;

class Program
{
    static void Main(string[] args)
    {
        var con1 = SqlBaglanti.GetSqlConnection();
        var con2 = SqlBaglanti.GetSqlConnection();
        var con3 = SqlBaglanti.GetSqlConnection();

        Console.WriteLine(con1.GetHashCode());
        Console.WriteLine(con2.GetHashCode());
        Console.WriteLine(con3.GetHashCode());

        Temp temp1 = new Temp();
        Temp temp2 = new Temp();
        Temp temp3 = new Temp();

        Console.WriteLine(temp1.GetHashCode());
        Console.WriteLine(temp2.GetHashCode());
        Console.WriteLine(temp3.GetHashCode());
    }
}

