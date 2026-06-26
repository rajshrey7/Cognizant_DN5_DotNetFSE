using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using System;
using System.Linq;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("========== EAGER LOADING ==========\n");

            var products = context.Products
                                  .Include(p => p.Category)
                                  .ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"Product : {product.Name}");
                Console.WriteLine($"Category : {product.Category.Name}");
                Console.WriteLine($"Price : ₹{product.Price}");
                Console.WriteLine();
            }

            Console.WriteLine("========== EXPLICIT LOADING ==========\n");

            var firstProduct = context.Products.First();

            context.Entry(firstProduct)
                   .Reference(p => p.Category)
                   .Load();

            Console.WriteLine($"Product : {firstProduct.Name}");
            Console.WriteLine($"Category : {firstProduct.Category.Name}");

            Console.WriteLine();
            Console.WriteLine("========== LAZY LOADING ==========\n");

            var lazyProduct = context.Products.First();

            Console.WriteLine($"Product : {lazyProduct.Name}");
            Console.WriteLine($"Category : {lazyProduct.Category.Name}");

            

        }
    }  
}