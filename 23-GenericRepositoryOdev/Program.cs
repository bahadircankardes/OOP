using _23_GenericRepositoryOdev.Entities;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Npgsql;

namespace _23_GenericRepositoryOdev;

/*Kurulacak Paketler : Dapper, Dapper.Contrib, MySql, System.Data.SqlServer
 Npgsql*/

class Program
{
    public static string pgconstr = "User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=sakila;";
    public static string mysqlconstr = "Server=localhost;Database=sakila;Uid=root;Pwd=41264126;";

    static void Main(string[] args)
    {
        MySqlConnection mySqlConnection = new MySqlConnection(mysqlconstr);
        NpgsqlConnection npgsqlConnection = new NpgsqlConnection(pgconstr);

        Actor actor = new Actor()
        {
            actor_id = 201 ,
            first_name = "Bahadir Can",
            last_name = "Kardes",
            last_update = DateTime.Now
        };


        //var gelenid = mySqlConnection.Insert<Actor>(actor);

        var gelenid2 = npgsqlConnection.Insert<Actor>(actor);

    }
}

