using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;
using Dapper;
using _18_DapperSampleAndRepositeryPattern.NorthwindDTOs;
using _18_DapperSampleAndRepositeryPattern.Models;
using _18_DapperSampleAndRepositeryPattern.NorthwindManagers;

namespace _18_DapperSampleAndRepositeryPattern;

class Program
{
    static void Main(string[] args)
    {
        string sql = "select * from shippers";
        string dapperSelect = "select * from customers";


        //string sqlConstr = "server =.;Database=Northwind;Thrusted_Connection=true;ThrustedServerCertificate=true";
        string pgConstr = "User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=Northwind;";
        //SqlConnection sqlcon = new SqlConnection(sqlConstr);
        //NpgsqlConnection npgcon = new NpgsqlConnection(pgConstr);

        //IDbConnection sqlcon = new SqlConnection(sqlConstr);
        IDbConnection npgcon = new NpgsqlConnection(pgConstr);

        //IDbCommand sqlcmd = sqlcon.CreateCommand();
        //sqlcmd.CommandText = sql;
        IDbCommand pgcmd = npgcon.CreateCommand();
        pgcmd.CommandText = dapperSelect;

        #region Postgres'den veri cekme
        //npgcon.Open();
        //IDataReader reader = pgcmd.ExecuteReader();
        //while (reader.Read())
        //{
        //    Console.WriteLine(reader[0].ToString());
        //    Console.WriteLine(reader[1].ToString());
        //    Console.WriteLine(reader[2].ToString());

        //}
        //npgcon.Close();

        #endregion

        #region Dapper ile Kullanım


        //var result = npgcon.Query<CustomerSelectDTO>(dapperSelect).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.customer_id}  {item.company_name}  {item.contact_name}");
        //}
        #endregion

        #region Dapper ile StoredProcedure
        //ÇAlışmadı o prosedur bende yok

        //string dapperSelect = "exec UlkeBazindaYillikCiro @ulke, @yil";
        //var parametreler= new { ulke = "UK", yil = 1997 };//Anonim object
        //var result = sqlCon.Query<UlkeBazindaCiro>(dapperSelect,parametreler);

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.Ay} {item.Ciro} ");
        //}

        #endregion

        #region Basic Generic Repository Kullanimi

        Product armut = new Product()
        {
            ProductId = 79,
            ProductName = "Armut",
            Discontinued = 1,
            UnitPrice = 50,
            UnitsInStock = 23
        };

        ProductManager productManager = new ProductManager(npgcon);
        productManager.Insert(armut);
        #endregion

        Console.ReadLine();

    }
}

