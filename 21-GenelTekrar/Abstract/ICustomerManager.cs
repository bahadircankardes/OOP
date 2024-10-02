using System;
namespace _21_GenelTekrar.Abstract
{
	public interface ICustomerManager
	{
        public Customer GetById(int id);

        public List<Customer> GetAll();

        public long Insert(Customer input);

        public long Update(Customer input);

        public long Delete(Customer input);
    }
}

