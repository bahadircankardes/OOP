using System;
using System.Data;
using _18_DapperSampleAndRepositeryPattern.GenericRepository.Abstract;

namespace _18_DapperSampleAndRepositeryPattern.GenericRepository.Concrete
{
    public class Manager<T>(IDbConnection db) : IManager<T> where T : class
    {
        public T Delete(T input)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetByQuery(string sql)
        {
            throw new NotImplementedException();
        }

        public T Insert(T input)
        {
            throw new NotImplementedException();
        }

        public T Update(T input)
        {
            throw new NotImplementedException();
        }
    }
}

