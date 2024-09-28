using System.Data.SqlClient;

namespace _16_ExtensionMetodlar;

internal class Program
{
    static void Main(string[] args)
    {
        string kelime = "çşığöü";
        Console.WriteLine(kelime.TurkceKarakterleriTemizle());

        SqlConnection connection = new SqlConnection();
        Console.WriteLine(connection.BaglantiDurumuNedir());

    }
}

