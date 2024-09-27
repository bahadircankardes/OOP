using System;
using _11_Interface.FirinOrnegi.Abstract;

namespace _11_Interface.FirinOrnegi.Concrete
{
	public class KaraFirin
	{
		//public void EkmekPisir(Makine makine)
		//{
		//	makine.HamurYogur();
		//}

  //      public void EkmekPisir(Usta usta)
  //      {
  //          usta.HamurYogur();
  //      }

		public void EkmekPisir(IYogurabilir yogurucu)
		{
			yogurucu.HamurYogur();
		}
		
    }
}

