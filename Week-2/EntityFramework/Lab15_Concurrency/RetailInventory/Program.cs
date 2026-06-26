using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using System;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context1 = new AppDbContext();
            using var context2 = new AppDbContext();

            var product1 = context1.Products.First();
            var product2 = context2.Products.First();

            product1.StockQuantity += 10;
            context1.SaveChanges();

            product2.StockQuantity += 20;

            try
            {
                context2.SaveChanges();

                Console.WriteLine("Update Successful.");
            }
            catch (DbUpdateConcurrencyException)
            {
                Console.WriteLine("Concurrency conflict detected.");
            }

          
        }
    }
}