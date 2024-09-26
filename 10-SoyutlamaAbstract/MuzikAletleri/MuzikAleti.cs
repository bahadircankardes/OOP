using System;
namespace _10_SoyutlamaAbstract.MuzikAletleri
{
	public abstract class MuzikAleti
	{
		public string Marka { get; set; }
		public string Model { get; set; }

		/*Cal() metodu her müzik aletinin calma yontemi farkli 
		 * oldugundan cal () metodunu abstract metod olmasi gerekir*/

		//public string Cal()
		//{
		//	return "";
		//}

		public abstract string Cal();
        public abstract string AkordYap();


    }
}

