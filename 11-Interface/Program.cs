using _11_Interface.Personeller;

namespace _11_Interface;

class Program
{
    static void Main(string[] args)
    {
        Personel personel = new Personel();
        Sekreter sekreter = new Sekreter();
        SatisPersoneli satisPersoneli = new SatisPersoneli();
        SatisMuduru satisMuduru = new SatisMuduru();

        #region Interface Konu Anlatimi

        /* Interface'ler heap'de tutulur,
         * Interface'lerden Intance alinamaz.
         * Interface'ler ayni zmaanda bir tiptir.
         */

        IPersonel personel1 = new SatisMuduru();
        ISatisPersoneli satisPersoneli1 = new SatisMuduru();

        #endregion



    }
}

