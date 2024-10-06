namespace _27_EventTrafik;


class Program
{

    /*Bir arac 120 km hızı gecince trafik polisi ceza kessin.
     *Su tarihte su plakali aracın abc isimli soforune su polis saatte 
     *x km hizla gittigi için y miktarinda ceza kesmis.
     *mesajı sms atilsin, teblig edilsin
     */
    static void Main(string[] args)
    {
        #region Tanimlama
        Sofor sofor = new Sofor("Can Deniz Kardes");

        Araba araba = new Araba(sofor, "Toyota CH-R", "39 AC 859");

        Polis polis = new Polis("Rıza Cezakeser");

        araba.HareketEdiyorum += polis.HizKontrolEt;
        sofor.GazaBastim += araba.Calis;

        sofor.GazaBas();
        #endregion


        
    }

   
}

