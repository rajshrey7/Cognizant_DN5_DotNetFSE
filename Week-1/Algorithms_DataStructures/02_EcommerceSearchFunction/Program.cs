using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id,
                   string name,
                   string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
    }
}

class Program
{
    static Product LinearSearch(
        Product[] products,
        string name)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(
                name,
                StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }

        return null;
    }

    static Product BinarySearch(
        Product[] products,
        string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int result =
                string.Compare(
                    products[mid].ProductName,
                    name,
                    true);

            if (result == 0)
                return products[mid];

            if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(
                101,
                "Laptop",
                "Electronics"),

            new Product(
                102,
                "Mouse",
                "Electronics"),

            new Product(
                103,
                "Keyboard",
                "Electronics"),

            new Product(
                104,
                "Monitor",
                "Electronics")
        };

        Console.WriteLine(
            "===== LINEAR SEARCH =====\n");

        Product linearResult =
            LinearSearch(
                products,
                "Mouse");

        Console.WriteLine(linearResult);

        Array.Sort(
            products,
            (a, b) =>
            a.ProductName.CompareTo(
                b.ProductName));

        Console.WriteLine(
            "\n===== BINARY SEARCH =====\n");

        Product binaryResult =
            BinarySearch(
                products,
                "Mouse");

        Console.WriteLine(binaryResult);

        Console.WriteLine(
            "\n===== TIME COMPLEXITY =====");

        Console.WriteLine(
            "Linear Search : O(n)");

        Console.WriteLine(
            "Binary Search : O(log n)");
    }
}