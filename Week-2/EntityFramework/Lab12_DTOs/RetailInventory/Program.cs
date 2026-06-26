using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.DTOs;
using System;
using System.Linq;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            var productDTOs = context.Products
                                     .Include(p => p.Category)
                                     .Select(p => new ProductDTO
                                     {
                                         Name = p.Name,
                                         Price = p.Price,
                                         CategoryName = p.Category.Name
                                     })
                                     .ToList();

            foreach (var product in productDTOs)
            {
                Console.WriteLine($"Product Name : {product.Name}");
                Console.WriteLine($"Price        : ₹{product.Price}");
                Console.WriteLine($"Category     : {product.CategoryName}");
            }

            Console.WriteLine("\nDTO Projection Completed Successfully.");

        }
    }
}