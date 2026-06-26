using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("========== ALL PRODUCTS ==========");

            var products = context.Products.ToList();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id}  {p.Name}  ₹{p.Price}");
            }

            Console.WriteLine();

            Console.WriteLine("========== FIND BY ID ==========");

            var product = context.Products.Find(1);

            if (product != null)
            {
                Console.WriteLine($"Found Product : {product.Name}");
            }

            Console.WriteLine();

            Console.WriteLine("========== EXPENSIVE PRODUCT ==========");

            var expensive = context.Products
                                   .FirstOrDefault(p => p.Price > 50000);

            if (expensive != null)
            {
                Console.WriteLine($"Expensive Product : {expensive.Name}");
            }

            Console.WriteLine();

            Console.WriteLine("Lab 5 Completed Successfully.");
        }
    }
}