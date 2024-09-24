namespace _5_Kalitim;
using _5_Kalitim.Computer;
using _5_Kalitim.SirketPersonel;

class Program

#region Konu Anlatimi
/* Bir class ancak ve ancak tek bir calssdan inherit alabilir.
 * 
 */
#endregion
{
    static void Main(string[] args)
    {
        //BaseType baseType = new BaseType();
        //baseType.Marka = "Asus";
        //baseType.Model = "Vivobook";
        //baseType.Fiyat = 1000;
        //AnaKart anaKart = new AnaKart();
        //anaKart.Marka = "Asus";

        //ITTasarimci iTTasarimci = new ITTasarimci();
        //Temp temp = new Temp();
        //Console.WriteLine(temp.ToString());
        //Object obj = new Object();
        //Console.WriteLine(obj.ToString());


        #region Constructor'li sinif kullanimi
        Sekreter sekreter = new Sekreter();
        sekreter.Adi = "Hulya";

        SatisMuduru satisMuduru = new SatisMuduru();
        satisMuduru.Adi = "Turgut";
        Console.WriteLine(satisMuduru.Maas);



        #endregion






    }
}

