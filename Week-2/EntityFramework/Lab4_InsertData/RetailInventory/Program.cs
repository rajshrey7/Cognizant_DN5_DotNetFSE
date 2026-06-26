using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            var electronics = new Category
            {
                Name = "Electronics"
            };

            var groceries = new Category
            {
                Name = "Groceries"
            };

            context.Categories.Add(electronics);
            context.Categories.Add(groceries);

            context.SaveChanges();
            var product1 = new Product
            {

                Name = "Laptop",
                Price = 75000,
                CategoryId = electronics.Id
            };

            var product2 = new Product
            {
                Name = "Rice Bag",
                Price = 1200,
                CategoryId = groceries.Id
            };

            context.Products.Add(product1);
            context.Products.Add(product2);

            context.SaveChanges();

            Console.WriteLine("====================================");
            Console.WriteLine(" Data Inserted Successfully!");
            Console.WriteLine("====================================");

            Console.WriteLine("Categories Added:");
            Console.WriteLine("- Electronics");
            Console.WriteLine("- Groceries");

            Console.WriteLine();

            Console.WriteLine("Products Added:");
            Console.WriteLine("- Laptop");
            Console.WriteLine("- Rice Bag");
        }
    }
}