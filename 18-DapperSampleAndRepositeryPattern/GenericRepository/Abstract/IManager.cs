using System;
namespace _18_DapperSampleAndRepositeryPattern.GenericRepository.Abstract
{
	public interface IManager <T> where T:class
	{
        public List<T> GetByQuery(string sql);
        public  T GetById(int id);
        public List<T> GetAll();
        public T Insert(T input);
        public T Update(T input);
        public T Delete(T input);


    }
}

