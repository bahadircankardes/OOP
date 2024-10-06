using System;
namespace _28_EventYangin
{
	public class Itfaiye
	{
		public void MudahaleEt(object yardimcagiran)
		{
			if (yardimcagiran is Alarm)
			{
				Console.WriteLine("Itfaiye yangina mudahale etti.");
			}
		}

		
	}
}

