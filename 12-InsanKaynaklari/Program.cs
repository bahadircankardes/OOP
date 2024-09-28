using _12_InsanKaynaklari.Abstract;
using _12_InsanKaynaklari.Concrete;

namespace _12_InsanKaynaklari;

class Program
{
    static void Main(string[] args)
    {
        Kisi bahadir = new()
        {
            Ad = "Bahadir Can",
            Soyad = "Kardes",
            Cinsiyet = true,

        };

        Kisi gulin = new()
        {
            Ad = "Gulin",
            Soyad = "Kardes",
            Cinsiyet = false,

        };

        ITBasvuru iTBasvuru = new();
        iTBasvuru.Kisi = bahadir;
        iTBasvuru.isHtml = true;
        iTBasvuru.isCss = true;
        iTBasvuru.isLinq = true;
        iTBasvuru.isEF = false;
        iTBasvuru.departman = Departman.Yazilim;

        ITBasvuru iTBasvuru2 = new();
        iTBasvuru2.Kisi = gulin;
        iTBasvuru2.isHtml = true;
        iTBasvuru2.isCss = true;
        iTBasvuru2.isLinq = true;
        iTBasvuru2.isEF = true;
        iTBasvuru2.departman = Departman.Yazilim;


        IKBasvurusu insankaynaklari = new IKBasvurusu();
        insankaynaklari.ITBasvurusuAl(iTBasvuru);
        insankaynaklari.ITBasvurusuAl(iTBasvuru2);

        insankaynaklari.GenelBasvuruAl(iTBasvuru);
        insankaynaklari.GenelBasvuruAl(iTBasvuru2);

        insankaynaklari.GenelBasvuruListele();


    }
}

