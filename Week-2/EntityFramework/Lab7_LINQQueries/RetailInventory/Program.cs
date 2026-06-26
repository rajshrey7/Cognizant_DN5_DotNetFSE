using System;
using System.Linq;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("========== PRODUCTS WITH PRICE > 1000 ==========\n");

            var filteredProducts = context.Products
                                          .Where(p => p.Price > 1000)
                                          .OrderByDescending(p => p.Price)
                                          .ToList();

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Id : {product.Id}");
                Console.WriteLine($"Name : {product.Name}");
                Console.WriteLine($"Price : ₹{product.Price}");
                Console.WriteLine();
            }

            Console.WriteLine("========== PRODUCT DTO ==========\n");

            var productDTOs = context.Products
                                     .Select(p => new
                                     {
                                         p.Name,
                                         p.Price
                                     })
                                     .ToList();

            foreach (var product in productDTOs)
            {
                Console.WriteLine($"Name : {product.Name}");
                Console.WriteLine($"Price : ₹{product.Price}");
                Console.WriteLine();
            }

            Console.WriteLine("Lab 7 Completed Successfully.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}