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

        #region Otomobil

        Otomobil reno = new Otomobil();
        reno.Marka = "Renault";
        reno.Cekis = Cekis.OndenCekis;
        reno.KasaTipi = KasaTipi.Hatchback;
        reno.Vites = Vites.Otomatik;
        reno.Model = "Toros";
        reno.CikisYili = new DateOnly(1977, 5, 19);
        Console.WriteLine($"Marka: {reno.Marka}");
        Console.WriteLine($"Cekis: {reno.Cekis}");
        Console.WriteLine($"KasaTipi: {reno.KasaTipi}");
        Console.WriteLine($"Vites: {reno.Vites}");
        Console.WriteLine($"Model: {reno.Model}");
        Console.WriteLine($"ModelYili: {reno.CikisYili}");
        Console.WriteLine("***************************");
        #endregion

        #region CepTelefonu

        CepTelefonu cepTelefonu = new CepTelefonu();
        cepTelefonu.Marka = Marka.Apple;
        cepTelefonu.Model = "İphone16";
        cepTelefonu.RamKapasitesi = RamKapasitesi._32Gb;
        cepTelefonu.DahiliHafiza = DahiliHafiza._64Gb;
        cepTelefonu.EkranBoyutu = EkranBoyutu._6_8_inch;

        Console.WriteLine($"Marka: {cepTelefonu.Marka}");
        Console.WriteLine($"Model: {cepTelefonu.Model}");
        Console.WriteLine($"RamKapasitesi: {cepTelefonu.RamKapasitesi}");
        Console.WriteLine($"DahiliHafiza: {cepTelefonu.DahiliHafiza}");
        Console.WriteLine($"Ekranboyutu: {cepTelefonu.EkranBoyutu}");
        #endregion


        #region Kitap
        Kitap kitap = new Kitap();
        kitap.KitapAdi = "Hayat İmkansiz";
        kitap.Yazar = "Matt Haig";
        kitap.Cevirmen = "Kivanc Guney";
        kitap.YayinEvi = "Domingo Yayinevi";
        kitap.HamurTipi = HamurTipi.İkinciHamur;
        kitap.SayfaSayisi = "368";
        kitap.Ebat = "14 x 21";
        kitap.IlkBaskiYili = "2024";
        kitap.BaskiSayisi = BaskiSayisi.BirinciBasim;
        kitap.Dili = Dili.Turkce;
        kitap.Barkod = "9786051983226";
        Console.WriteLine($"KitapAdi: {kitap.KitapAdi}");
        Console.WriteLine($"Yazar: {kitap.Yazar}");
        Console.WriteLine($"Cevirmen: {kitap.Cevirmen}");
        Console.WriteLine($"YayinEvi: {kitap.YayinEvi}");
        Console.WriteLine($"HamurTipi: {kitap.HamurTipi}");
        Console.WriteLine($"SayfaSayisi: {kitap.SayfaSayisi}");
        Console.WriteLine($"Ebat: {kitap.Ebat}");
        Console.WriteLine($"İlkBaskiYili: {kitap.IlkBaskiYili}");
        Console.WriteLine($"BaskiSayisi: {kitap.BaskiSayisi}");
        Console.WriteLine($"Dili: {kitap.Dili}");
        Console.WriteLine($"Barkod: {kitap.Barkod}");


        #endregion


        #endregion

    }
}

