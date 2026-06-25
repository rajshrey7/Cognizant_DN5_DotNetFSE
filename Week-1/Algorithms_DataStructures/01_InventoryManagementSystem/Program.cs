using System;
using System.Collections.Generic;

class Product
{
    public int ProductId;
    public string ProductName;
    public int Quantity;
    public double Price;

    public Product(int id, string name,
                   int quantity, double price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = quantity;
        Price = price;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Quantity: {Quantity}, Price: {Price}";
    }
}

class Program
{
    static Dictionary<int, Product> inventory =
        new Dictionary<int, Product>();

    static void AddProduct(Product p)
    {
        inventory[p.ProductId] = p;
        Console.WriteLine(
            "Product Added: " + p.ProductName);
    }

    static void UpdateProduct(
        int id,
        int quantity)
    {
        if (inventory.ContainsKey(id))
        {
            inventory[id].Quantity = quantity;

            Console.WriteLine(
                "Product Updated Successfully");
        }
    }

    static void DeleteProduct(int id)
    {
        inventory.Remove(id);

        Console.WriteLine(
            "Product Deleted Successfully");
    }

    static void DisplayProducts()
    {
        foreach (var product in inventory.Values)
        {
            Console.WriteLine(product);
        }
    }

    static void Main()
    {
        Console.WriteLine(
            "===== ADD PRODUCTS =====");

        AddProduct(
            new Product(
                101,
                "Laptop",
                10,
                50000));

        AddProduct(
            new Product(
                102,
                "Mouse",
                20,
                500));

        Console.WriteLine(
            "\n===== CURRENT INVENTORY =====");

        DisplayProducts();

        Console.WriteLine(
            "\n===== UPDATE PRODUCT =====");

        UpdateProduct(101, 15);

        Console.WriteLine(
            "\n===== INVENTORY AFTER UPDATE =====");

        DisplayProducts();

        Console.WriteLine(
            "\n===== DELETE PRODUCT =====");

        DeleteProduct(102);

        Console.WriteLine(
            "\n===== FINAL INVENTORY =====");

        DisplayProducts();

        Console.WriteLine(
            "\n===== TIME COMPLEXITY =====");

        Console.WriteLine(
            "Add    -> O(1)");

        Console.WriteLine(
            "Update -> O(1)");

        Console.WriteLine(
            "Delete -> O(1)");
    }
}