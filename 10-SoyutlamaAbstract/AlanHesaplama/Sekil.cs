using System;
namespace _10_SoyutlamaAbstract.AlanHesaplama
{
    #region KonuAnlatimi
    //abstract siniflar instance vermez, kalitim verir.
    #endregion


    public abstract class Sekil
        //inherit alinir instance(new) alinamaz.
	{
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        /*Abstract metodlarin govdesi olmaz. Yani kod tanimlamalari
         * kalitim alan yerlerde tanimlamak zorundadir.
         * 
         * Abstract metodlar abstract classlar icerisinde olur.
         */
        public abstract double AlanHesapla();
        public abstract double CevreHesapla();

        /*Virtual metodlar sanal metodlar ve govdesi yazilir.
         * Virtual metodlar abstract olsun olmasın butun class'larda yazılabilir.
         */

        public virtual string BilgileriGoster()
        {
            return $"Bu Seklin Kisa Kenari = {KisaKenar}, Uzun Kenari = {UzunKenar}";
        }
    }
}

