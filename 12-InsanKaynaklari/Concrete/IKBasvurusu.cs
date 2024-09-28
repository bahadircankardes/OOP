using System;
using _12_InsanKaynaklari.Abstract;

namespace _12_InsanKaynaklari.Concrete
{
	public class IKBasvurusu
	{
        List<ITBasvuru> iTBasvurulari = new List<ITBasvuru>();
        //HasSet'ler listeye bir adet object girmesini garanti eder.

        HashSet<ITBasvuru> iTBasvuru = new HashSet<ITBasvuru>();
		HashSet<FinansBasvuru> finansBasvurulari = new HashSet<FinansBasvuru>();
		HashSet<object> GenelBasvurular = new HashSet<object>();

		public void ITBasvurusuAl(ITBasvuru basvuru)
		{
			iTBasvuru.Add(basvuru);
		}

		public void FinansBasvurusuAl(FinansBasvuru finansBasvuru)
		{
			finansBasvurulari.Add(finansBasvuru);
		}

		public void GenelBasvuruAl(object Basvuru)
		{
			GenelBasvurular.Add(Basvuru);
		}

		public void GenelBasvuruListele()
		{
			foreach (var item in GenelBasvurular)
			{
				if (item is ITBasvuru)
				{
					ITBasvuru basvuru = (ITBasvuru)item;
					Console.WriteLine(basvuru.departman+ " " +basvuru.Kisi);
				}

				else if (item is FinansBasvuru)
				{
					Console.WriteLine(((FinansBasvuru)item).departman + " " + ((FinansBasvuru)item).Kisi);

				}
			}
		}
	}
}

