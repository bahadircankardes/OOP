namespace _33_DictionaryVe_OzelListeler;

class Program
{
    static void Main(string[] args)
    {
        #region Dictionary
        //Key VAlue degerleri tutan ozel listelerdir.
        //List<string> list = new List<string>();
        //Dictionary<string, string> dict = new Dictionary<string, string>();
        //dict.Add("apple", "elma");
        //dict.Add("cat", "kedi");
        //dict.Add("heart", "kalp");

        //foreach (var item in dict)
        //{
        //    Console.WriteLine($"{item.Key} => {item.Value}");
        //}

        //Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
        //dict2.Add($"apple", new List<string>() { "elma", "dag elmasi", "kirmizi elma"});

        //Dictionary<object, object> objectDic = new Dictionary<object, object>();


        #endregion

        #region Stack List

        //LIFO: Son giren ilk cıkar. Last in First Out

        //Stack<int> stack = new Stack<int>();

        ////Eleman eklemek icin Push metodu kullanilir
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);
        //stack.Push(5);
        //stack.Push(6);
        //stack.Push(7);
        //stack.Push(8);

        //foreach (var item in stack)
        //{
        //    Console.WriteLine(item.ToString());
        //}
        //Console.WriteLine("****************");

        ////Eleman Cikartmak icin Pop metodu kullanilir.

        //stack.Pop();
        //stack.Pop();
        //foreach (var item in stack)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        #endregion

        #region Queue Kuyruk
        ////First in First Out FIFO
        //Queue<int> sayilar = new Queue<int>();

        ////Kuyruğa ekleme
        //sayilar.Enqueue(1);
        //sayilar.Enqueue(2);
        //sayilar.Enqueue(3);
        //sayilar.Enqueue(4);
        //sayilar.Enqueue(5);
        //sayilar.Enqueue(6);
        //sayilar.Enqueue(7);
        //sayilar.Enqueue(8);

        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        //Console.WriteLine("****************");
        ////Kuyruktan Cıkarma
        //sayilar.Dequeue();
        //sayilar.Dequeue();
        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item.ToString());
        //}


        #endregion

        #region SortedList
        //Listeye eklenen elemanlari otomatik olarak siralar

        //SortedList<int, string> haftaningunleri = new SortedList<int, string>();
        //haftaningunleri.Add(1, "Pazar");
        //haftaningunleri.Add(4, "Carsamba");
        //haftaningunleri.Add(2, "Pazartesi");
        //haftaningunleri.Add(3, "Sali");
        //haftaningunleri.Add(6, "Cuma");
        //haftaningunleri.Add(7, "Cumartesi");
        //haftaningunleri.Add(5, "Persembe");


        //foreach (var item in haftaningunleri)
        //{
        //    Console.WriteLine($"{item.Key}=> {item.Value}");
        //}

        #endregion

        #region HashSet
        //Uzerine eklenen objeleri GetHashCode ile kontrol edip
        //ona gore ekleme yapar.
        //HashSet<Kisi> kisis = new HashSet<Kisi>();
        //Kisi ali = new Kisi { AdSoyad = "Ali Nur" };
        //Kisi veli = new Kisi { AdSoyad = "Veli Deli" };

        //kisis.Add(ali);
        //Console.WriteLine(ali.GetHashCode());
        //kisis.Add(ali);
        //kisis.Add(veli);
        //Console.WriteLine(veli.GetHashCode());

        //kisis.Add(veli);
        //kisis.Add(ali);
        //kisis.Add(veli);

        //foreach (var item in kisis)
        //{
        //    Console.WriteLine(item.AdSoyad);
        //}
        #endregion

        #region Tuple
        //
        Kisi ali = new Kisi { AdSoyad = "Ali" };
        Tuple<int, string, Kisi> tuple = new Tuple<int, string, Kisi>(1, "ali", ali);
        Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " "+ tuple.Item3.AdSoyad);
        #endregion
    }

    public class Kisi
    {
        public string AdSoyad { get; set; }
    }
}

