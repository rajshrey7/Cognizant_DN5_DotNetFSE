using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("===================================");
            Console.WriteLine(" Retail Inventory System");
            Console.WriteLine("===================================");
            Console.WriteLine("DbContext Created Successfully.");
            Console.WriteLine("Database Connection Configured.");
            Console.WriteLine();
        }
    }
}