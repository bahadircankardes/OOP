namespace _1_Giris;

struct Kisi
{
    public int sayi;
    public string ad, soyad;
    public DateTime dogumTarihi;
    string TcNo;

    public void SetTcNo(string tc)
    {
        if (!string.IsNullOrEmpty(tc) && tc.Length == 11)
        {
            TcNo = tc;
        }
    }

    public string GetTcNo()
    {
        if (!string.IsNullOrEmpty(TcNo))
        {
            return ("*******" + TcNo.Substring(7));
        }

        else
        {
            return "Deger Atanamais";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region Capsulation

        #region Struct Kullanimi
        //Kisi kisi = new Kisi();
        //kisi.sayi = 1;
        //kisi.ad = "Bahadir";
        //kisi.soyad = "Kardes";
        //kisi.dogumTarihi = DateTime.Now;
        //kisi.SetTcNo("12123455467");
        //Console.WriteLine(kisi.sayi + " " + kisi.ad + " " + kisi.soyad + " " + kisi.dogumTarihi + " " + kisi.GetTcNo());

        #endregion
        #endregion

        #region Class Kullanimi
        Otomobil reno = new Otomobil();
        reno.Marka = "Renault";
        reno.Cekis = Cekis.OndenCekis;
        reno.KasaTipi = KasaTipi.Hatchback;
        reno.Vites = Vites.Otomatik;
        reno.Model = "Toros";
        reno.CikisYili = new DateOnly(1977, 5, 19);
        Console.WriteLine("Gitti mi");


        #endregion

    }
}

