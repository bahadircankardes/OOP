using System;
using _18_DapperSampleAndRepositeryPattern.Models;

namespace _18_DapperSampleAndRepositeryPattern.NorthwindManagers
{
	public class ShipperManager
	{

        public List<Shipper> GetByQuery(string sql)
        {
            return new List<Shipper>();
        }
        public static Shipper GetById(int id)
        {

            return new Shipper();
        }

        public static List<Shipper> GetAll(int id)
        {

            return new List<Shipper>();
        }

        public int Insert(Shipper shipper)
		{
			return 1;
		}

        public int Update(Shipper shipper)
        {
            return 1;
        }

        public int Delete(Shipper shipper)
        {
            return 1;
        }
    }
}

