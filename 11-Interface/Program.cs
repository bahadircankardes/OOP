using _11_Interface.FirinOrnegi.Concrete;
using _11_Interface.Loglama.Abstract;
using _11_Interface.Loglama.Concrete;
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


        #region Firin Ornegi

        Usta usta = new Usta() { Adi = "Hasan Usta" };
        Makine makine = new Makine() { Adi = "Bosch" };
        KaraFirin karaFirin = new KaraFirin();
        karaFirin.EkmekPisir(usta);
        karaFirin.EkmekPisir(makine);

        #endregion

        #region Loglama Ornegi
        #region Concrete
        DosyaLoglayici dosyaLoglayici = new DosyaLoglayici();
        SmsLoglayici smsLoglayici = new SmsLoglayici();
        DbLoglayici dbLoglayici = new DbLoglayici();
        #endregion
        #region Interface ile Yapimi
        ILogger dosyaloglayici = new DosyaLoglayici();
        ILogger smslogger = new SmsLoglayici();
        #endregion

        Logger logger = new Logger();

        logger.Log(dosyaloglayici,"Test");
        logger.Log(smslogger, "TEst2");
        #endregion



    }
}