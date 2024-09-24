using _2_ClassOrnekleri.Computer;

namespace _2_ClassOrnekleri;

class Program
{
    static void Main(string[] args)
    {
        #region VeriGirisi 1.Yol Property'lere tek tek deger atanmasi
        
        CPU cpu = new CPU();
        cpu.Marka = "AMD";
        cpu.Model = "Ryzen";
        cpu.CoreSayisi = 8;
        cpu.Fiyat = 300;

        #region Veri Girisinde 2. Yol Object initialize edilmesi ile olur. 
        AnaKart AnaKart = new AnaKart()
        {
            Marka = "Asus",
            Model = "XYZ",
            Fiyat = 300,
            BellekTipi = BellekTipi.DDR2,
            IslemciTipi = IslemciTipi.Intel
        };

        AnaKart.Marka = "Asus";

        /*asagidaki kodda kasa degiskeni stack de tutulur.
         * icerisinde new operatorunun verdigi heap deki adres alani vardir.
         
         */

        Kasa kasa = new Kasa();
        kasa.Marka = "Asus";
        kasa.Model = "xvc";

        /*asagidaki kodda kasa2 degiskeni stack de tutulur.
       * icerisinde new operatorunun verdigi heap deki adres alani vardir.
       * Ancak sonradan kasa degiskeninin tutugu adres alani kasa2 ye atandigindan
       * artik her iki stack de duran degısken de atni adres bolgesini tutmaktadir.
       * Dolayiyle herhangi birinde yapilacak degisiklik digerini de etkileyecek.
       */

        Kasa kasa2 = new Kasa();
        kasa2 = kasa;
        kasa2.Marka = "ABC";

        Console.WriteLine(kasa.Marka);
        Console.WriteLine(kasa2.Marka);

        kasa2.Model = "QWE";
        Console.WriteLine(kasa.Model);
        Console.WriteLine(kasa2.Model);

        #endregion

        //Bir class içerisindeki veri tipi class olanlarin daha onceden ınstance i
        //alinmis olmalidir.
        OyuncuBilgisayari oyuncu = new OyuncuBilgisayari();

        Ram ram = new Ram() {Marka="Kingston", Model="QWERTY", BellekTipi= BellekTipi.DDR4 };
        oyuncu.Ramler.Add(ram);


        WissenComputer computer = new WissenComputer();
        computer.Fiyat = 1000;
        computer.Cpu = cpu;
        computer.AnaKart = AnaKart;
        computer.Ramler = new List<Ram>();
        computer.Ramler.Add(new Ram { Marka = "ABC", Model = "CVB", BellekTipi = BellekTipi.DDR2, Kapasite = 16, Fiyat = 3000, RamHizi = 3 });
        computer.Ramler.Add(ram);
        #endregion

        
    }
}

