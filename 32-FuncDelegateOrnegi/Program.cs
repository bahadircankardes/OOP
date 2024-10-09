using MySql.Data.MySqlClient;
using Npgsql;
using Dapper;
using _32_FuncDelegateOrnegi.Models;

namespace _32_FuncDelegateOrnegi;

public class Kisi
{
    public int Id { get; set; }
    public string AdSoyad { get; set; }
    public DateOnly DogumTarihi { get; set; }
    public bool Cinsiyet { get; set; }

    public Kisi(int id, string adsoyad, DateOnly dogumtarihi, bool cinsiyet)
    {
        Id = id;
        AdSoyad = adsoyad;
        DogumTarihi = dogumtarihi;
        Cinsiyet = cinsiyet;

    }

    public override string ToString()
    {
        return $"{Id} {AdSoyad} {DogumTarihi} {Cinsiyet}";
    }
}

class Program
{
    public static string npglconstr = "User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=Northwind;";
    public static string mysqlconstr = "Server=localhost;Database=northwind;Uid=root;Pwd=41264126;";

    static void Main(string[] args)
    {
        #region Komplex Data Tiplerinin Func delegate İle Sorgulanmasi
        //Kisi ali = new Kisi(1, "Ali", new DateOnly(2000, 1, 6), true);
        //Kisi veli = new Kisi(2, "Veli", new DateOnly(2001, 2, 6), true);
        //Kisi ayse = new Kisi(3, "Ayse", new DateOnly(2002, 3, 8), false);
        //Kisi fatma = new Kisi(4, "Fatma", new DateOnly(2002, 4, 9), false);
        //Kisi hasan = new Kisi(5, "Hasan", new DateOnly(2004, 8, 10), true);

        //List<Kisi> kisilistesi = new List<Kisi>() { ali, veli, ayse, fatma, hasan };

        //Console.WriteLine("***********Erkek olanlarin listesi****************");
        ////Erkek olanlarin listesi
        //var erkekler = kisilistesi.Where(kisi => kisi.Cinsiyet == true).ToList();
        //erkekler.ForEach(erkek => Console.WriteLine(erkek));

        //Console.WriteLine("************Kiz olanlarin listesi***************");
        ////Kiz olanlarin listesi
        //var kizlar = kisilistesi.Where(kisi => kisi.Cinsiyet == false).ToList();
        //kizlar.ForEach(kiz => Console.WriteLine(kiz));

        //Console.WriteLine("*********ıd si 3'ten buyuk olanlar******************");
        ////Kisi ıd si 3'ten buyuk olanlarin listesi
        //var result = kisilistesi.Where(kisi => kisi.Id > 3).ToList();//Predicate daha da özelinde aslinda Func Delegate'dir.
        //result.ForEach(item => Console.WriteLine(item));//Generic action delegate ile temsil edilmistir.

        //Console.WriteLine("************2002 dogumluluar***************");
        ////2002 dogumluluarin listesi
        //var result1 = kisilistesi.Where(kisi => kisi.DogumTarihi.Year == 2002).ToList();
        //result1.ForEach(item => Console.WriteLine(item));

        //Console.WriteLine("*************2002 dogumlu kizlar**************");
        ////2002 dogumlu kizlar
        //var result2 = kisilistesi.Where(kisi => kisi.DogumTarihi.Year == 2002 && kisi.Cinsiyet == false).ToList();
        //result2.ForEach(item => Console.WriteLine(item));

        //Console.WriteLine("************hem erkek hem de dogum günü 6. gun olanlar***************");
        ////hem erkek hem de dogum günü 6. gun olanlar
        //var result3 = kisilistesi.Where(kisi => kisi.DogumTarihi.Day == 6 && kisi.Cinsiyet == true).ToList();
        //result3.ForEach(item => Console.WriteLine(item));

        //Console.WriteLine("************Agustos ayinda doganlarin listesi***************");
        ////Agustos ayinda doganlarin listesi
        //var result4 = kisilistesi.Where(kisi => kisi.DogumTarihi.Month == 8).ToList();
        //result4.ForEach(item => Console.WriteLine(item));

        //Console.WriteLine("***************************");
        #endregion

        #region Dapper Ile Sorgulama

        string sql = "select * from customers";
        //MySqlConnection mySqlConn = new MySqlConnection(mysqlconstr);
        NpgsqlConnection npgsqlConn = new NpgsqlConnection(npglconstr);

        Console.WriteLine("*******NPGSQL__Almanyadaki Musteriler********************");
        var musterilernpg = npgsqlConn.Query<Customer>(sql).ToList();
        var almanlar = musterilernpg.Where(p=> p.country =="Germany").ToList();
        almanlar.ForEach(item=> Console.WriteLine($"{item.country}--> {item.company_name}"));

        //Console.WriteLine("*******MYSQL__Almanyadaki Musteriler********************");
        //var musterilermy = mySqlConn.Query<Customer>(sql).ToList();
        //musterilermy.Where().ToList();

        #endregion

        #region Sorular
        //Londradaki musteriler

        //Cozum 1:
        //sql += " where City='London'"; // Normal sql olusturma
        //sql += " where City=@city"; // Dapper da parametrik yapma 
        //var londraMusterileri = npgsqlConn.Query<Customer>(sql,new { city="London"}).ToList();
        //londraMusterileri.ForEach(item => Console.WriteLine($"{item.company_name} {item.city}"));

        Console.WriteLine("*******NPGSQL__Londradaki_Musteriler********************");
        var londras = musterilernpg.Where(p=>p.city =="London").ToList();
        londras.ForEach(item=>Console.WriteLine($"{item.city} {item.company_name}"));

        //Fax'i olmayan Musteriler

        Console.WriteLine("*******NPGSQL__Faxless_Customers********************");
        var faxless = musterilernpg.Where(p => p.fax is null).ToList();
        faxless.ForEach(item => Console.WriteLine($"{item.fax} {item.company_name}"));

        //Region olmayan musteriler
        Console.WriteLine("*******NPGSQL__Regionless_Customers********************");
        var regionless = musterilernpg.Where(p => p.region is null).ToList();
        regionless.ForEach(item => Console.WriteLine($"{item.customer_id} {item.company_name}"));

        //Contact title'ı Owner olan musteriler
        Console.WriteLine("*******NPGSQL__Owner_Customers********************");
        var owners = musterilernpg.Where(p => p.contact_title == "Owner").ToList();
        owners.ForEach(item => Console.WriteLine($"{item.contact_title} {item.company_name}"));

        //Unit price 20 usd den fazla olan urunleri bul

        //Yeniden baglanti yaptim.
        string sql1 = "select * from products";
        NpgsqlConnection npgsqlConn1 = new NpgsqlConnection(npglconstr);
        var urunlernpg = npgsqlConn1.Query<Product>(sql1).ToList();


        Console.WriteLine("*******NPGSQL__Unit_Price > 20_ Products********************");
        var urunler20 = urunlernpg.Where(p => p.unit_price > 20).ToList();
        urunler20.ForEach(item => Console.WriteLine($"{item.product_name} {item.unit_price}"));

        //Discontinued alani false olanların listesi
        Console.WriteLine("*******NPGSQL__Discontinued = 0_ Products********************");
        var urunler1 = urunlernpg.Where(p => p.discontinued == 0).ToList();
        urunler1.ForEach(item => Console.WriteLine($"{item.product_name}"));


        //50 adetten fazla siparis almis urunler hangileridir.

        Console.WriteLine("*******NPGSQL__orders > 50 _ Products********************");
        var urunler2 = urunlernpg.Where(p => p.units_on_order > 50).ToList();
        urunler2.ForEach(item => Console.WriteLine($"{item.product_name}"));

        //Product listesini alin ve category Id si 2 olanlari bulun

        Console.WriteLine("*******NPGSQL__Category_Id=2 Products********************");
        var urunler3 = urunlernpg.Where(p => p.category_id ==2).ToList();
        urunler3.ForEach(item => Console.WriteLine($"{item.product_name}"));
        #endregion

        #region MyRegion Complex sorgularda Dapper
        //Class Yaptik. 
        string sql2 = $@"select date_part('month', o.order_date) Ay, round(sum(od.unit_price * od.quantity )) Ciro
                     from orders o
                     inner join order_details od on od.order_id = o.order_id
                     where date_part('year', o.order_date) = @yil
                     group by date_part('month',o.order_date)";


        var sonuc = npgsqlConn.Query<AylikBazdaSorgu>(sql2, new {yil=1997}).ToList();
        sonuc.ForEach(p => Console.WriteLine($"{p.Ay} \t {p.Ciro} "));

        #endregion

        #region Kategorilerin Cirolarini Bulma

        //Yukarıdakine örnek
        string sql3 = $@"select p.category_id KategoriNo, c.category_name Kategori, round(sum(od.unit_price * od.quantity )) Ciro
                       from orders o
                       inner join order_details od on od.order_id = o.order_id
                       inner join products p on p.product_id = od.product_id
                       inner join categories c on c.category_id = p.category_id
                       group by Kategori, KategoriNo
                       order by Ciro desc";

        var result3 = npgsqlConn.Query<KategorilerinCiroları>(sql3).ToList();
        result3.ForEach(p=> Console.WriteLine($"{p.KategoriNo}\t{p.Kategori}\t{p.Ciro}"));
        #endregion


    }
}

