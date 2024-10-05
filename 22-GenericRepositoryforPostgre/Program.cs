using System.Data;
using _22_GenericRepositoryforPostgre.Abstract;
using _22_GenericRepositoryforPostgre.BussinessLayer;
using _22_GenericRepositoryforPostgre.Concrete;
using _22_GenericRepositoryforPostgre.Entities;
using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;

namespace _22_GenericRepositoryforPostgre;

class Program
{
    //Postgre uzerindeki Northwind db ye baglanmam icin paket hangisidir?
    //Npgsql__bu paket ADO.NET destegi verir.
    //Dapper-- Connection nesnesi uzerinde extra metodlar saglar(Query,Exec vb.).
    //Dapper.Contrib __ Connection nesnesi uzerinden Crud destegi saglar(Create,update,delete).

    public static string constr = "User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=Northwind;";


    static void Main(string[] args)
    {
        IDbConnection conn = new NpgsqlConnection(constr);


        #region Contrib PAketi olmadan insert ya da Crud islemi
        //conn.Open();
        #region Insert
        //string insertSql = $"insert into shippers (shipper_id,company_name,phone) values (14,'RedGo Kargo','0-900-600-5000') ";
        //string insertSql = $"insert into shippers (shipper_id,company_name,phone) values ('{9}','{"GreenGo Kargo"}','{"0-900-600-5000"}') ";
        //int gelenid = conn.Execute(insertSql);
        //Console.WriteLine(gelenid);

        #endregion

        #region Delete

        //string deletesql = "delete from shippers where shipper_id = 10 ";
        //Console.WriteLine(conn.Execute(deletesql));

        #endregion
        #endregion

        #region Dapper Contrip Paketi ile Calisma
        #region Insert
        //Shipper shipper = new Shipper() {shipper_id = 20, company_name= "YellowleGo", phone ="0-900-456-23-45"};
        //Console.WriteLine(conn.Insert(shipper));

        //Employee employee = new Employee() { employee_id=12, first_name= "Andre", last_name= "Kardes"};
        //Console.WriteLine(conn.Insert(employee));

        Shipper shipper = new Shipper() { shipper_id = 22, company_name = "osein", phone = "647 428 006" };
        //ınsert yaparken using System.ComponentModel.DataAnnotations; seçmek gerekiyor.
        // aksi takdirde hata veriyor..
        //conn.Insert(shipper);

        // ınsert yaparken using System.ComponentModel.DataAnnotations; seçmek gerekiyor.
        // aksi takdirde hata veriyor..
        #endregion

        #region Update
        // shippers da update yaparken using Dapper.Contrib.Extensions; olması gerekiyor yoksa
        // var updateshipper = conn.Get<Shipper>(20) "Get<T> only supports an entity with a [Key] or an [ExplicitKey] property";
        // uyarısı veriyor...  

        //var updateshipper = conn.Get<Shipper>(20);
        //updateshipper.company_name = "Yellow";
        //updateshipper.phone = "333 0 000";
        //conn.Update<Shipper>(updateshipper);
        #endregion
        #region Delete
        //using Dapper.Contrib.Extensions; olmalı update gibi davranıyor.


        //var deleteshipper = conn.Get<Shipper>(22);
        //conn.Delete<Shipper>(deleteshipper);
        #endregion

        #region Query
        //IEnumerable<Shipper> shippers = conn.Query<Shipper>("select * from shippers where company_name = 'DHL'");
        //foreach (var item in shippers)
        //{
        //    Console.WriteLine($"{item.shipper_id}, {item.phone}");
        //}
        #endregion

        #endregion
        //Her iki sekilde de yazılabilir.
        //Manager<Product> productmanager = new Manager<Product>(conn);
        IManager<Product> productmanager = new Manager<Product>(conn);

        #region Silme İslemi
        //var result = productmanager.GetById(79);
        //productmanager.Delete(result);
        //Console.WriteLine(result.product_name);
        #endregion

        #region Update ISlemi
        //var update = productmanager.GetById(78);
        //update.product_name = "Karpuz";
        //productmanager.Update(update);
        #endregion

        #region Insert Islemi
        //IManager<Shipper> shippermanager = new Manager<Shipper>(conn);
        //Shipper shipper1 = new Shipper() { shipper_id=22, company_name="Bullgo", phone="123345-45" };
        //shippermanager.Insert(shipper1);
        #endregion

        #region Query Islemi
        //Manager<Customer> customermanager = new Manager<Customer>(conn);
        //var input = customermanager.GetById("PARIS");
        //Console.WriteLine(input.contact_name);
        #endregion

        #region Override ToString MEtodu ile Customer i yazdirma
        //IManager<Customer> customermanager = new Manager<Customer>(conn);
        //var customerfind = customermanager.GetById("WELLI");
        //Console.WriteLine(customerfind); //ToString metodunu override ettigimiz icin
        #endregion

        try
        {
            ICustomerManager customermanager = new CustomerManager(conn); 
            Customer customer = new Customer()
            {
                customer_id = "BAHA",
                company_name = "BAHALONG LLC.",
                country = "Germany",
                city = "Berlin"
            };
            customermanager.Insert(customer);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }




    }
}

