using System;
namespace _14_PArtialClass
{
	public partial class Kisi
	{
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} {Cinsiyet}";
        }
    }
}

