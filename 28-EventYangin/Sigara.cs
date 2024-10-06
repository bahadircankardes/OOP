using System;
namespace _28_EventYangin
{
	public class Sigara
	{
		public event EventDelegate Yandim;
		public void SigaraIc()
		{
			Console.WriteLine("Sigara Yandi..");
			Yandim(this);
		}

		
	}
}

