namespace _20_EventKlima;

class Program
{
    static void Main(string[] args)
    {
        #region Tanımamalar

        Sensor sensor = new Sensor();
        Klima klima = new Klima();
        Fan fan = new Fan();
        #endregion

        #region Bağlamalar

        sensor.SicaklikDegisti += klima.Calıs;
        sensor.SicaklikDegisti += fan.Calıs;

        #endregion

        #region Tetikleyici

        sensor.SicaklikDegistir(25);
        Console.WriteLine("**************************");
        sensor.SicaklikDegistir(35);


        #endregion



    }
}

