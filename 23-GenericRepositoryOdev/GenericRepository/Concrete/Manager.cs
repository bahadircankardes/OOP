using System;
using System.Data;
using Dapper.Contrib.Extensions;
using _23_GenericRepositoryOdev.GenericRepository.Abstract;

namespace _23_GenericRepositoryOdev.GenericRepository.Concrete
{
    public class Manager<T>(IDbConnection db) : IManager<T> where T : class
    {
        public IEnumerable<T> GetAll()
        {
            return db.GetAll<T>();
        }

        public T GetById(int id)
        {
            return db.Get<T>(id);
        }

        public long Insert(T entity)
        {
            return db.Insert<T>(entity);
        }

        public bool Update(T entity)
        {
            return db.Update<T>(entity);
        }
        public bool Delete(T entity)
        {
            return db.Delete<T>(entity);
        }
    }
}

