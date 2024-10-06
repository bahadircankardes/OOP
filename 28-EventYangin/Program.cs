namespace _28_EventYangin;

class Program
{
    #region Konu

    /*Sigara, Kablo, alarm, itfaiye ve cesitli insanlar
     * 
     * Sigara icilsin, kablodan akim gecsin
     * 
     * sigara.icildi += insan.rahatsizoldu;
     * 
     * sigara.icildi += alarm.Cal;
     * 
     * kablo.KisaDevre += alarm.cal
     * 
     * alarm.cal += itfaiye.MudahaleEt;
     * alarm.cal += ayse.rahatsizol;
     * alarm.cal += ali.kac;
     * alarm.cal += fatma.rahatsizol;
     */
    #endregion

    
    static void Main(string[] args)
    {
        #region Instance Alma

        Insan ali = new Insan("Ali");
        Insan veli = new Insan("Veli");
        Insan ayse = new Insan("Ayse");
        Insan fatma = new Insan("Fatma");
        Insan hasan = new Insan("Hasan");

        Kablo kablo = new Kablo();
        Sigara sigara = new Sigara();

        Alarm alarm = new Alarm();
        Itfaiye itfaiye = new Itfaiye();

        #endregion

        #region Olaylari Baglama

        kablo.Yandim += alarm.AlarmCal;
        alarm.AlarmCaldi += ali.RahatsizOl;
        alarm.AlarmCaldi += veli.Kac;
        alarm.AlarmCaldi += ayse.RahatsizOl;
        alarm.AlarmCaldi += ayse.Kac;
        alarm.AlarmCaldi += fatma.RahatsizOl;

        alarm.AlarmCaldi += itfaiye.MudahaleEt;
        sigara.Yandim += alarm.AlarmCal;
        sigara.Yandim += itfaiye.MudahaleEt;

        #endregion

        #region Tetikleme

        kablo.AkimGecir();
        sigara.SigaraIc();

        #endregion

    }
}

