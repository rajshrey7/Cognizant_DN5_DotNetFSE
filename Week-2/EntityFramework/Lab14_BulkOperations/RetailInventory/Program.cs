using RetailInventory.Data;
using RetailInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Keyboard",
                    Price = 1500,
                    StockQuantity = 25,
                    CategoryId = 1
                },
                new Product
                {
                    Name = "Mouse",
                    Price = 800,
                    StockQuantity = 40,
                    CategoryId = 1
                },
                new Product
                {
                    Name = "Monitor",
                    Price = 12000,
                    StockQuantity = 15,
                    CategoryId = 1
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            Console.WriteLine("Bulk Insert Completed.");

            
            var allProducts = context.Products.ToList();

            foreach (var product in allProducts)
            {
                product.StockQuantity += 10;
            }

            context.SaveChanges();

            Console.WriteLine("Bulk Update Completed.");

            var deleteProducts = context.Products
                                        .Where(p => p.Price < 1000)
                                        .ToList();

            context.Products.RemoveRange(deleteProducts);
            context.SaveChanges();

            Console.WriteLine("Bulk Delete Completed.");

           
        }
    }
}