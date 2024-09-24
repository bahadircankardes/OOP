using _3_ClassLibrary.Okullar;
namespace _6_ObjectSinifi;


class Program
{
    #region Konu Anlatimi
    /* 1- Object sinifi C# da butun tiplerin atasidir.
     */
    #endregion
    static void Main(string[] args)
    {
        List<object> liste = new List<object>();
        liste.Add(1);
        liste.Add(new Brans {Id =1, BransAdi="Müzik" });
        liste.Add(new Sinif { Id = 1, Kapasite = 30, SinifAdi = "10A" });

        #region Cuvaldakileri Tek Tek secme ve ne olduguna karar verme

        //foreach (var item in liste)
        //{
        //    if (item is  Brans)
        //    {
        //        Console.WriteLine("Brans:" + item.ToString());
        //    }
        //    if (item is Sinif)
        //    {
        //        Console.WriteLine("Sinif");
        //    }
        //    else if (item is Int32)
        //    {
        //        Console.WriteLine("Int32");
        //    }

        //}
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

