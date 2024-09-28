using System;
using _12_InsanKaynaklari.Abstract;

namespace _12_InsanKaynaklari.Concrete
{
	public class FinansBasvuru:BaseBasvuru,IFinans
	{
        public bool isExcel { get; set; }
        public bool isLogo { get; set; }

        public void BilancoCikar()
        {
            Console.WriteLine($"{Kisi.Ad} {Kisi.Soyad} tarafından bilanco cikarilacak.");
        }

        public void KdvHesapla()
        {
            Console.WriteLine($"{Kisi.Ad} {Kisi.Soyad} tarafından KDV hesaplanacak.");
        }

        public void VergiHesapla()
        {
            Console.WriteLine($"{Kisi.Ad} {Kisi.Soyad} tarafından vergi hesaplanacak.");
        }
    }
}

