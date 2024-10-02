using System;
using System.Data;
using _21_GenelTekrar.Abstract;
using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;

namespace _21_GenelTekrar.Concrete
{
    public class Manager<T>(IDbConnection db) : IManager<T> where T : class
    {//IDbConnection yazarsak  sql veya postgre gondermen fark etmiyor.
     //NpgsqlConnection postgre için yazilabilir.
        public List<T> GetAll()
        {
            return db.GetAll<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Get<T>(id);
        }

        public T GetById(string id)
        {
            return db.Get<T>(id);
        }

        public long Insert(T input)
        {
            return db.Insert<T>(input);
        }

        public bool Update(T input)
        {
            return db.Update<T>(input);
        }

        public bool Delete(T input)
        {
            return db.Delete<T>(input);
        }

        public IEnumerable<T> GetQuery(string sql)
        {
            return db.Query<T>(sql);

        }

        
    }
}

