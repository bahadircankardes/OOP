using _3_ClassLibrary.Okullar;
using _3_ClassLibrary.Sinemalar;
using Faker;

namespace _4_LibraryKullanimi;

class Program
{
    static void Main(string[] args)
    {
        #region Kullanimi
        /*Oncelikli olarak kullanilacak kutuphane project referanslarina eklenmesi
         * gerekir.
         */
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Adi = Name.FullName();
        Console.WriteLine(ogrenci.Adi);
        Sinif sinif = new Sinif();
        Kategori kategori = new Kategori();

        #endregion


    }
}

