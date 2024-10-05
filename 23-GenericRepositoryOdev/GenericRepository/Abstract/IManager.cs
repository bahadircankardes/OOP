using System;
namespace _23_GenericRepositoryOdev.GenericRepository.Abstract
{
	public interface IManager<T> where T :class
	{
		public T GetById(int id);

		IEnumerable<T> GetAll();

		long Insert(T entity);

		bool Update(T entity);

		bool Delete(T entity);


	}
}

