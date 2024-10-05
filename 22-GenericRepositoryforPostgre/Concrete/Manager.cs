using System;
using System.Data;
using _22_GenericRepositoryforPostgre.Abstract;
using Dapper;
using Dapper.Contrib.Extensions;

namespace _22_GenericRepositoryforPostgre.Concrete
{
    public class Manager<T>(IDbConnection db) : IManager<T> where T : class
    {


        //Yukarida (IDbConnection db) yazmazsak
        //asagıdaki constractor tanımlayıp istememiz gerekecek

        //private readonly IDbConnection db;
        //public Manager(IDbConnection db)
        //{
        //    this.db = db;
        //}


        public virtual List<T> GetAll()
        {
            return db.GetAll<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return db.Get<T>(id);
        }

        public virtual T GetById(string id)
        {
            return db.Get<T>(id);
        }

        public virtual long Insert(T input)
        {
            return db.Insert<T>(input);
        }

        public virtual bool Update(T input)
        {
            return db.Update<T>(input);
        }

        public virtual bool Delete(T input)
        {
            return db.Delete<T>(input);
        }

        public virtual IEnumerable<T> GetQuery(string sql)
        {
            return db.Query<T>(sql);
        }

       
    }
}

