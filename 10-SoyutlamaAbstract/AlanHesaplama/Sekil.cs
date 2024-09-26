using System;
namespace _10_SoyutlamaAbstract.AlanHesaplama
{
    #region KonuAnlatimi
    //abstract siniflar instance vermez, kalitim verir.
    //abstract keyword'u sadece class'larda uygulanabilir.
    //Struct'lar abstract olarak isaretlenemezler.
    //Struct'lar sealed yani muhurlenmis yapilardir.
    // instance alinabilir ancak kalitim vermez.
    //Structlar hafizada stack'de tutulur. Bu nedenle
    //classlara göre daha hizlidir.
    //
    #endregion


    public abstract class Sekil
        //inherit alinir instance(new) alinamaz.
	{
        //Abstract ve virtual  keywordleri ancak metod ve
        //propertilere verilebilir. Field alanlari virtual ve abstract
        //olarak isaretlenemez
        //public double toplam = 0; bir fielddir.



        /* abstract kelimesi propertilere de verilebilir
         * virtual kelimesi de propertilere de verilebilir.
         * 
         * egerki abstract olarak class icerisinde her ne isaretlenmis ise
         * kalitim verdigi yerlerde mutlaka override zorunda iken
         * virtual olarak isaretlenen class memberları yeniden override 
         * edilmek zorunda degildir. Cunku virtual metodlarin ya da prop'larin 
         * govdesi olmak zorundadir.
         * 
         * Abstract metodlar ve property ler de ise govdesi olmaz.
         */
        public abstract int KisaKenar { get; set; }
        public virtual int UzunKenar { get; set; }
        /*Abstract metodlarin govdesi olmaz. Yani kod tanimlamalari
         * kalitim alan yerlerde tanimlamak zorundadir.
         * 
         * Abstract metodlar abstract classlar icerisinde olur.
         */
        public abstract double AlanHesapla();
        public abstract double CevreHesapla();

        /*Virtual metodlar sanal metodlardir ve govdesi yazilir.
         * Virtual metodlar abstract olsun olmasın butun class'larda yazılabilir.
         *Virtual olarak isaretlendiyse override etmek zorunda degilsin
         *Fakat abstract ise override etmek zorundasin*/

        public virtual string BilgileriGoster()
        {
            return $"Bu Seklin Kisa Kenari = {KisaKenar}, Uzun Kenari = {UzunKenar}";
        }

        public override string ToString()
        {
            return $"Kisa Kenar:{KisaKenar}, Uzun Kenar: {UzunKenar} ";
        }
    }
}

