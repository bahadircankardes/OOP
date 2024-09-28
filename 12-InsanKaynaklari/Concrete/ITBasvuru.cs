using System;
using _12_InsanKaynaklari.Abstract;

namespace _12_InsanKaynaklari.Concrete
{
	public class ITBasvuru:BaseBasvuru,IYazilim
	{
		public bool isLinq { get; set; }
		public bool isEF { get; set; }
		public bool isHtml { get; set; }
        public bool isCss { get; set; }
        public bool isBootstrap { get; set; }

        public void AnalitikDusun()
        {
            throw new NotImplementedException();
        }

        public void DurmadanOgren()
        {
            throw new NotImplementedException();
        }

        public void KodGelistir()
        {
            throw new NotImplementedException();
        }
    }
}

