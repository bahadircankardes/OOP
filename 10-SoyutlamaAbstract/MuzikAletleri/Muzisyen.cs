using System;
namespace _10_SoyutlamaAbstract.MuzikAletleri
{
	public class Muzisyen
	{
		public string AdSoyad { get; set; }

		public string MuzikAletiCal(Flut flut)
		{
			return $"{AdSoyad} {flut.Marka} aletini caldi";
		}
        public string MuzikAletiCal(Gitar gitar)
        {
            return $"{AdSoyad} {gitar.Marka} aletini caldi";
        }

        public string MuzikAletiCal(Piyano piyano)
        {
            return $"{AdSoyad} {piyano.Marka} aletini caldi";
        }

        public void MuzikAletleriCal(List<MuzikAleti> caldigialetler)
        {
            foreach (var item in caldigialetler)
            {
                Console.WriteLine($"{AdSoyad} {item.Cal()}");
                Console.WriteLine($"Caldigi Aletin Markası: {item.Marka}, Modeli: {item.Model}");
            }
        }
    }
}

