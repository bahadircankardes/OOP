using System;
namespace _21_GenelTekrar.Abstract
{
	public interface IShipperManager
	{
		public Shipper GetById(int id);

		public List<Shipper> GetAll();

		public long Insert(Shipper input);

		public long Update(Shipper input);

        public long Delete(Shipper input);
    }
}

