using Dapper;
using System.Data.SqlClient;
using Npgsql;
using Dapper.Contrib.Extensions;
using _21_GenelTekrar.Abstract;
using _21_GenelTekrar.Concrete;

namespace _21_GenelTekrar;

class Program
{
    public static string constr = "User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=Northwind;";
    public static NpgsqlConnection npgcon = new NpgsqlConnection(constr);
    static void Main(string[] args)
    {
        //Shipper kargocu = new Shipper() {shipper_id= 13, company_name="Kongo Kargo", phone = "6-590-156-122" };
        //var sonuc = npgcon.Insert<Shipper>(kargocu);
        //Console.WriteLine(sonuc);

        IManager<Shipper> shippermanager = new Manager<Shipper>(npgcon);
        IManager<Customer> customermanager = new Manager<Customer>(npgcon);
        IManager<Product> productmanager = new Manager<Product>(npgcon);
        IManager<Employee> employeemanager = new Manager<Employee>(npgcon);



        var result = shippermanager.GetAll();

        foreach (var item in result)
        {
            Console.WriteLine($"{item.shipper_id} {item.company_name} {item.phone?.ToString() ?? "N/A"}");
        }
        Console.WriteLine("******************************************");

        var result1 = customermanager.GetAll();
        foreach (var item in result1.Take(5))
        {
            Console.WriteLine($"{item.customer_id} {item.company_name} {item.country}");
        }
        Console.WriteLine("******************************************");

        var result2 = productmanager.GetAll();
        foreach (var item in result2.Take(5))
        {
            Console.WriteLine($"{item.product_id} {item.product_name} {item.discontinued}");
        }
        Console.WriteLine("******************************************");

        var result3 = employeemanager.GetAll();
        foreach (var item in result3)
        {
            Console.WriteLine($"{item.employee_id} {item.first_name} {item.last_name}");
        }
        Console.WriteLine("******************************************");


        //Sorgu islemi
        var customers = customermanager.GetQuery("select * from customers where country = 'UK'");
        foreach (var item in customers)
        {
            Console.WriteLine($"{item.customer_id} {item.company_name} {item.country}");
        }

        //Silme Islemi
        //var dokuzusil = shippermanager.GetById(13); //silme islemi yapmak icin one getırıyoruz
        //shippermanager.Delete(dokuzusil); //Sonra siliyoruz


        //Degistirme islemi

        var shipper = shippermanager.GetById(8);
        shipper.phone = "444 1 444";
        shipper.company_name = "Maras Kargo";
        shippermanager.Update(shipper);

        var result11 = shippermanager.GetAll();

        foreach (var item in result11)
        {
            Console.WriteLine($"{item.shipper_id} {item.company_name} {item.phone?.ToString() ?? "N/A"}");
        }
    }
}

