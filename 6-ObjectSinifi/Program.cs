using _3_ClassLibrary.Okullar;
namespace _6_ObjectSinifi;


class Program
{
    #region Konu Anlatimi
    /* 1- Object sinifi C# da butun tiplerin atasidir.
     * 2- Object sinifi ile birlikte gelen 4 adet metod vardir.
     *  Equels = iki nesnenin esit olma durumunu inceler bool deger doner.
     *  ToString() = objenin namespace ini ve sinif ismini geri doner
     *  GetHashCopde () = .Net alt yapsiinda olusturulan her bir obje icin 
     *  bir kod uretilir. Metod da bize ureti,lmis olan nesnenin kodunu verir
     *  
     *  GetType () = Refleksion yapmamizi yani obje icerisindeki butun memberlari
     *  dolasmaya yarar.
     */
    #endregion
    static void Main(string[] args)
    {
        var brans = new Brans { Id = 1, BransAdi = "Müzik" };
        var brans2 = new Brans { Id = 1, BransAdi = "Müzik" };
        var sinif = new Sinif { Id = 1, Kapasite = 30, SinifAdi = "10A" };
        #region Equals metodu

        //iki nesneyi karsilastirip geriye true ya da false doner.
        //Fakat karsilastirdigi nesnelerin degerleri degil hashcode'laridir.
        //Bu kodlar ayni ise true doner, Yukaridaki ornekte brans ve brans2
        // degerlerı aynı olmasina ragmen ciktisi false doner.Nesneler birbirine
        //atanirsa true doner.
        brans2 = brans;
        Console.WriteLine(brans.Equals(brans2));


        #endregion

        #region ToString() Metodu

        //Nesnein namespace ve class ismini verir.
        Console.WriteLine(brans);
        #endregion

        List<object> liste = new List<object>();
        liste.Add(1);
        liste.Add(brans);
        liste.Add(sinif);
        liste.Add(DateTime.Now);


        #region Cuvaldakileri Tek Tek secme ve ne olduguna karar verme
        // is operatoru true ya da false doner iki nesneyi karsilastirir.
        // as operatoru ise objeyı belirtilen nesneye cevirir
        foreach (var item in liste)
        {
            
            if (item is Brans)
            {
                Console.WriteLine("Brans:" + item.ToString());
                Console.WriteLine("Brans:" + (item as Brans).BransAdi);
            }
            if (item is Sinif)
            {
                Console.WriteLine("Sinif" + (item as Sinif).SinifAdi);
            }
            else if (item is Int32)
            {
                Console.WriteLine("Int32");
            }

        }
        #endregion

        #region Reflection ile class'larin metod ve propertilerine ulaşma
        //GetType() metodu ile işler yapilir. Bu metod object
        //sinifina ait bir metoddur

        //Ogrenci ogrenci = new Ogrenci();
        //ogrenci.Adi = "Ali";
        //ogrenci.SoyAdi = "Yilmaz";
        //ogrenci.DogumYili =  new DateTime(1986,05,23);
        //ogrenci.TcNo = "12312345676";
        //var propertiler = ogrenci.GetType().GetProperties();
        //var metodlar = ogrenci.GetType().GetMethods();
        //foreach (var item in metodlar)
        //{
        //    Console.WriteLine(item.Name);

        //}

        //Console.WriteLine("**************************");


        //foreach (var item in propertiler)
        //{
        //    Console.WriteLine(item.Name);

        //}

        #endregion




    }
}

