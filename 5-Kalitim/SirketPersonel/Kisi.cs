using System;
namespace _5_Kalitim.SirketPersonel
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }

        public Kisi()
        {
            Adi = "";
            Soyadi = String.Empty;
            TcNo = String.Empty;
        }

        public Kisi(string ad, string soyad)
        {
            Adi = ad;
            Soyadi = soyad;
            
        }

        public Kisi(string ad, string soyad, string tcNo) : this (ad, soyad)
        {
            
            TcNo = tcNo;

        }
        public Kisi(string ad, string soyad, string tcNo, string gsm) : this (ad, soyad, tcNo)
        {
            
            Gsm = gsm;

        }
    }
}

