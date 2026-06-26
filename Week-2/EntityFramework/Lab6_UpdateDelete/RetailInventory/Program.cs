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

            Console.WriteLine("========= BEFORE UPDATE =========");

            foreach (var p in context.Products.ToList())
            {
                Console.WriteLine($"{p.Id}  {p.Name}  ₹{p.Price}");
            }

            // Update Laptop Price
            var product = context.Products
                                 .FirstOrDefault(p => p.Name == "Laptop");

            if (product != null)
            {
                product.Price = 70000;
                context.SaveChanges();

                Console.WriteLine("\nLaptop price updated successfully.");
            }

            // Delete Rice Bag
            var deleteProduct = context.Products
                                       .FirstOrDefault(p => p.Name == "Rice Bag");

            if (deleteProduct != null)
            {
                context.Products.Remove(deleteProduct);
                context.SaveChanges();

                Console.WriteLine("Rice Bag deleted successfully.");
            }

            Console.WriteLine("\n========= AFTER UPDATE =========");

            foreach (var p in context.Products.ToList())
            {
                Console.WriteLine($"{p.Id}  {p.Name}  ₹{p.Price}");
            }
        }
    }
}