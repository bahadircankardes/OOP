using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
	public class Makina2
	{
        public void Isle(IDilimlenebilir dilimlenebilir)
        {
            dilimlenebilir.Dilimle();
        }
    }
}

