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

            Console.WriteLine("Tracking Query");
            var trackedProduct = context.Products.First();

            trackedProduct.Price = trackedProduct.Price + 1000;

            context.SaveChanges();

            Console.WriteLine("Price updated successfully using Tracking.");
            Console.WriteLine($"New Price : ₹{trackedProduct.Price}");

            Console.WriteLine();

            Console.WriteLine("No Tracking Query");

            var noTrackingProduct = context.Products
                                           .AsNoTracking()
                                           .First();

            Console.WriteLine($"Product : {noTrackingProduct.Name}");
            Console.WriteLine($"Price   : ₹{noTrackingProduct.Price}");

            Console.WriteLine();
            Console.WriteLine("AsNoTracking() retrieves data without tracking changes.");

        }
    }
}