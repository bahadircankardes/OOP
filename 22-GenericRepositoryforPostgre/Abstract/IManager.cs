using System;
namespace _22_GenericRepositoryforPostgre.Abstract
{
	public interface IManager<T> where T : class
	{
        public T GetById(int id);

        public T GetById(string id);

        public List<T> GetAll();

        public long Insert(T input);

        public bool Update(T input);

        public bool Delete(T input);

        public IEnumerable<T> GetQuery(string sql);


    }
}

