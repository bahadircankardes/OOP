using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
	public class Makina3
	{
        public void Isle(IBicilebilir bicilebilir)
        {
            bicilebilir.Bic();
        }
    }
}

