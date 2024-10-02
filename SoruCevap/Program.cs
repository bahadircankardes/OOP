namespace SoruCevap;

class Program
{
    static void Main(string[] args)
    {

    }
}
//Interfaceler Concrete class lardan inherit alamazalar.
//Bu kod hata  verir.
//interface ITest:TestClass
//{

//}


//Interface'ler abstract classlardan kalıtım alamazlar.
//Bu kod hata verir
#region Constructer
/* Soru  : Constructer Nedir ?
    * Cevap : 1-Bir class'dan instance alindiginda ilk calisan yapici metoddur.
    *           Yani  class olusurken bazi property yada field'lari set etmek isteyebilirsin. 
    *           Boyle bir durumda constructer ihtiyac duyulur.
    *       2- Eger ki sinif olusturulurken bazi prametreleri zorunlu girilmesini istiyorsaniz bu durumda 
    *           paramaetreli constucter kullanilir. 
    *           Asagidaki personel sinifi mutlaka adsoyad ve tcno bilsini instance alinirken ister. 
    *           Sonradan Degistirilemez. Bunun icin sa set medodu silinir yada private hale getirilir.
    */
//Personel personel = new Personel("Ali Can", "123123123");
            //personel.AdSoyad = "lksdflksdfkj";


            //Soru : Constructer her class'da olmak zorunda mi ?
            //cevap : Hayir olmak zorunda degil . Ancak Compiler her durumda bir default constructer koyar 
            #endregion


            #region Property
            /*
             * Property Nedir ?: Bir class'a ozellik kazandiran yapilardir. 
             * Ozelikleri de ulasmak yada ozelligi degistirmek icin get ve set metodlari olan ozel yapilardir.
             * Bu durumda encapsulate islemi denir. Kontrollu veri alis verisi yapmamiza olanak sağlar.
             * Eger get ve set metodlarinda bir sey yazilmaz ise buna boş property yada dumy property denir.
             * 
             * 
             * 
             */
            #endregion

            #region Class larda Metod Kavrami 
            /*
             * Metodlar Ne ise yarar ?
             * Metodlar class'lara yetenek kazandirir.
             * 
             * 
             */
            //{
//                Matematik.Karekok(3);
//                Araba araba = new Araba("Bmw", "3.20");
//araba.Start();
//                araba.Stop();
//            }
           
            #endregion

            #region Static Kavrami
            // Static class'lardan instance alinamaz. 
            // Cunku hafiza da heap de yer almazlar. Statik bolgede bulunurlar.
            // Static bolgedeki memeber'larin yasam dongusu program başlayinca başlar , kapatilinca biter.
            // Static bir class icerisinde static olmayan bir metod bulunaiblir mi ? Hayir bulunamaz
            // Ama Normal bir class icerisinde statik bir metod bulunabilir.

            //Matematik.Karekok(3);
#endregion

#region Kalitim
// Tanim :Kabaca  Class'larin ozeliklerini ve yeteneklerini başka bir class'a aktarma durumuna kalitim denir.
// Kalitim icin as olan erişim belirteci ve seald olup olmadigidir.
// Sealed keyword'u ile isaretlenen class'lar kalitim vermez. Sadece instance alinabilir.(yani new'lenebilir)
// Abstract class'larda Sadece kalitim verir. Instance Alinmaz.
// Bir class ancak bir class'tan inherit alabilirken bir cok interface'den kalitim alabilirler.


#region Abstraction , Soyutlama
// Abstract keyword'u class'lara ,metodlara ve property'lere verilebilir.
// Metosdlar ve property'ler icin bu  sart ancak abstract classlarda mümkündür.
// YAni normal class'lar icerisinde abstract member'lar yazilamaz.
// Abstract metodlar tanimlandigi yerde govdesi olamaz . 
// Bir metod abstract class icerisinde olsun olmasin virtual olarak isaretlenebilir


#region Interface
// Interface'ler bir class'a yetenek kazandirir. Yani class'in yeteneklerini tanimladimiz yerdir.
// Ayni zamanda class icin bir yol gostericidir. NE yapmasi gerektigini soyler .
// Gunluk hayatta genellikle siniflarin yetenekleri ile daha cok ilgileniriz. 
// Yani yapabildikleri ile ilgileniriz.
// Ornek olarak Bir futbolcunun yetenekleri on plandadir. Yada işe alim yapilacak bir deparman icin 
// Kisinin yetenekleri öne cikar. Bir araba aldiginizda arabanin yetenekleri fiyatini belirler. 
// Dolayisi ile yetenekleri onceden tanimlanamis yani metodlarin ne olacagi belirlenmis yapilardir.
// Bir cesit kontrattir diyebiliriz.

#endregion
#endregion
#endregion


interface ITest1 :ITest2
{

}

interface ITest2
{

}
class TestClass
{
    public string Name { get; set; }
}

abstract class TestAbstract
{
    public int MyProperty { get; set; }
}



