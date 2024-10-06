namespace _26_EventBomba;

class Program
{
    static void Main(string[] args)
    {
        #region Tanımlama

        Bomba bomba = new Bomba();
        Telefon telefon = new Telefon();
        telefon.KelimeKullanildiEvent += bomba.Patla;

        #endregion

        telefon.Gorusme();


    }
}

