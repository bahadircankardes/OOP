using System;
using System.Data.SqlClient;

namespace _7_SingletonPattern
{
	public class SqlBaglanti
	{
        private static SqlConnection sqlConnection;
        private static string constr = "server=.;Database=northwind;trusted_Connection=true";
        


        private SqlBaglanti()
        {

        }

        public static SqlConnection GetSqlConnection()
            //nesne olusumunu garantı eder bu metod
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(constr);
            }
            return sqlConnection;
        }

    }
}

