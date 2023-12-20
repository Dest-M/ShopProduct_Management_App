﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp4.Models;

namespace WinFormsApp4.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly string _connectionString;
        public ShopRepository(string conn)
        {
            _connectionString = conn;
        }

        public void InitialiseShopProcedures()
        {

        }
        public List<Shop> GetShops()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"SELECT s.ShopId, s.Name, p.ProductId, p.Name FROM [dbo].[Shop] s 
                            INNER JOIN [dbo].[ShopProduct] sp ON sp.ShopId = s.ShopId
                            INNER JOIN [dbo].[Product] p ON p.ProductId = sp.ProductId"
                ;

                var shops = connection.Query<Shop, Product, Shop>(sql, (shop, product) =>
                {
                    shop.Products = new List<Product> { product };
                    return shop;
                }, splitOn: "ProductId").ToList();

                var result = shops.GroupBy(p => p.ShopId).Select(g =>
                {
                    var groupedShop = g.First();
                    groupedShop.Products = g.Select(p => p.Products.Single()).ToList();
                    return groupedShop;
                }).ToList();

                return result;
            }
        }

        public void Create(Shop shop)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO [dbo].[Shop] (Name) VALUES(@Name)";
                db.Execute(sqlQuery, shop);

            }
        }

        public void AddProduct(Product product, Shop shop)
        {
            List <Product> products = shop.Products;
            products.Add(product);
            using (IDbConnection db = new SqlConnection(_connectionString))
            {

               
               var sqlQuery = @$"INSERT INTO [dbo].[Product] (Name) VALUES (product.Name);

                                INSERT INTO [dbo].[ShopProduct] (ShopId, ProductId) VALUES @shop.ShopId, {product.ProductId}";

                db.Execute(sqlQuery, param: shop);
            }
        }

        public void DeleteProduct(Product product, Shop shop)
        {
            

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = @"DELETE FROM [dbo].[ShopProduct] WHERE [dbo].[ShopProduct].ProductId = product.ProductId";
                db.Execute(sqlQuery, param: product);
            }

        }

        public void DeleteShop(Shop shop)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = @"DELETE FROM [dbo].[ShopProduct] WHERE [dbo].[ShopProduct].ShopId = @shop.ShopId;
                                 DELETE FROM [dbo].[Shop] WHERE [dbo].[Shop].ShopId = @shop.ShopId";
                db.Execute(sqlQuery, param: shop);
            }
        }

    }
}

    

