using System;
using System.Data;
using _22_GenericRepositoryforPostgre.Abstract;
using _22_GenericRepositoryforPostgre.Concrete;
using _22_GenericRepositoryforPostgre.Entities;

namespace _22_GenericRepositoryforPostgre.BussinessLayer
{
	public class CustomerManager:Manager<Customer>,ICustomerManager
	{
        private readonly IDbConnection db;

        public CustomerManager(IDbConnection db) : base(db)
        {
            this.db = db;
        }

        //Is kurallarina  Berlin'de bir müsteri istemiyorum
        //güncellemesi geldi.

        public override long Insert(Customer input)
        {
            if (!MusteriAlmanyadaMı(input))
            {
                return base.Insert(input);
            }
            else
            {
                throw new Exception("Berlin'de Yeni Bir Musteri Açilamaz! ");
            }
        }
        public bool MusteriAlmanyadaMı(Customer customer)
        {
            return customer.country.ToLower() != "berlin";
        }

        
    }
	
}

