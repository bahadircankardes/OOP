using System;
namespace _21_GenelTekrar.Abstract
{
	public interface IManager<T> where T : class
	{
        public T GetById(int id);//Diger tablolarda serial int otomatik artan idi.

        public T GetById(string id); //Customers listesinde ıd string tipinde


        public List<T> GetAll();

        public IEnumerable<T> GetQuery(string sql);

        public long Insert(T input);

        public bool Update(T input);

        public bool Delete(T input);
    }
}

