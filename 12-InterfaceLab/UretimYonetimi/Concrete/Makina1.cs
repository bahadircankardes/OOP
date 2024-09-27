using System;
using _12_InterfaceLab.UretimYonetimi.Abstract;

namespace _12_InterfaceLab.UretimYonetimi.Concrete
{
	public class Makina1
	{
		public void Isle(IKesilebilir kesilebilir)
		{
			kesilebilir.Kes();
		}
        //     public void Isle(params IKesilebilir kesilebilir)
        //     {
        //foreach (var item in kesilebilir)
        //{
        //             item.Kes();

        //         }
        //     }
        //Bu sekilde yaparsak Program.cs de
        //makina1.Isle(ceviz, kestane); iki veya daha
        //fazla degisken girebilirsiniz

    }
}

