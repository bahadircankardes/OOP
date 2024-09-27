using System;
using _11_Interface.Personeller.Abstract;

namespace _11_Interface.Personeller
{
    public class InsanKaynaklari : Personel, IInsanKaynaklari,IIstenCikartabilir,IIsGorusmesiYapabilir
	{//Interface ınterface'den kalitim alabilir.
	
        public int MyProperty { get ; set ; }

        public void OryantasyonYap()
		{

		}

        public void IsIlaniVerap()
        {

        }

        public void IstenCikar()
        {
            
        }

        public void IsGorusmesiYap()
        {
           
        }
    }
}

