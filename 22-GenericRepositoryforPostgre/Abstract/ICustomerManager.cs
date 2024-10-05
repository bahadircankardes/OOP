using System;
using _22_GenericRepositoryforPostgre.Entities;

namespace _22_GenericRepositoryforPostgre.Abstract
{
	public interface ICustomerManager : IManager<Customer>
	{

		public bool MusteriAlmanyadaMı(Customer customer);
	}
}

