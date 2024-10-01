using System;
using System.Data;
using _18_DapperSampleAndRepositeryPattern.GenericRepository.Abstract;
using _18_DapperSampleAndRepositeryPattern.Models;
using Dapper;

namespace _18_DapperSampleAndRepositeryPattern.NorthwindManagers
{
    public class ProductManager(IDbConnection db) : IManager<Product>
    {


        public List<Product> GetAll()
        {
            return db.Query<Product>("select * from products").ToList();
        }

        public Product? GetById(int id)
        {
            return db.Query<Product>($"select * from products where product_id={id}").FirstOrDefault();
        }

        public List<Product> GetByQuery(string sql)
        {
            return db.Query<Product>(sql).ToList();
        }

        public Product Insert(Product input)
        {
            string insertSql = "insert into Products (product_id, product_name, discontinued, units_in_stock, unit_price) values(@ProductId,@ProductName, @Discontinued, @UnitsInStock, @UnitPrice)";
            db.Execute(insertSql, new { ProductId = input.ProductId,ProductName = input.ProductName, Discontinued = input.Discontinued, UnitsInStock =input.UnitsInStock, UnitPrice = input.UnitPrice });
            return input;
        }

        public Product Update(Product input)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product input)
        {
            throw new NotImplementedException();
        }
    }
}

