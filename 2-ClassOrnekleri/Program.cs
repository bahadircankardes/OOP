using _2_ClassOrnekleri.Computer;

namespace _2_ClassOrnekleri;

class Program
{
    static void Main(string[] args)
    {
        #region VeriGirisi 1.Yol Property'lere tek tek deger atanmasi
        //Bir class içerisindeki veri tipi class olanlarin daha onceden ınstance i
        //alinmis olmalidir.

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

        /*
         
         */

        Kasa kasa = new Kasa();
        kasa.Marka = "Asus";
        kasa.Model = "xvc";

        Kasa kasa2 = new Kasa();
        kasa2 = kasa;
        kasa2.Marka = "ABC";

        Console.WriteLine(kasa.Marka);
        Console.WriteLine(kasa2.Marka);

        kasa2.Model = "QWE";
        Console.WriteLine(kasa.Model);
        Console.WriteLine(kasa2.Model);

        #endregion

        WissenComputer computer = new WissenComputer();
        computer.Fiyat = 1000;
        computer.Cpu = cpu;
        computer.AnaKart = AnaKart;

        #endregion

        
    }
}

