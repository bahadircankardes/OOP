using System;
using _12_InterfaceLab.FutbolOrnegi.Abstract;

namespace _12_InterfaceLab.FutbolOrnegi.Concrete
{
	public class Takim
	{
        //ReadOnly keywordu ile tanimlanan her neyse ya tanimlandigi yerde
        // deeger atamasi yapilabilir ya da Constructor icinde deger
        // atamasi yapilabilir
        private readonly List<BaseFutbolcu> futbolcular;

        public Takim(List<BaseFutbolcu> futbolcular)
		{
            this.futbolcular = futbolcular;
        }

        public override string ToString()
        {
            string sonuc = string.Empty;
            foreach (var futbolcu in futbolcular)
            {
                sonuc = sonuc + futbolcu.ToString();
            }
            return sonuc;
        }
    }
}

