using System;
using _18_DapperSampleAndRepositeryPattern.GenericRepository.Abstract;
using _18_DapperSampleAndRepositeryPattern.Models;

namespace _18_DapperSampleAndRepositeryPattern.NorthwindManagers
{
	public class CustomerManager:IManager<Customer>
	{

        public List<Customer> GetByQuery(string sql)
        {
            return new List<Customer>();
        }
        public Customer GetById(int id)
        {

            return new Customer();
        }

        public List<Customer> GetAll()
        {

            return new List<Customer>();
        }

        Customer IManager<Customer>.Insert(Customer input)
        {
            throw new NotImplementedException();
        }

        Customer IManager<Customer>.Update(Customer input)
        {
            throw new NotImplementedException();
        }

        Customer IManager<Customer>.Delete(Customer input)
        {
            throw new NotImplementedException();
        }
    }
}

