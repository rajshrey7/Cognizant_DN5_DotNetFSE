using System;

class Order
{
    public int OrderId;
    public string CustomerName;
    public double TotalPrice;

    public Order(int orderId,
                 string customerName,
                 double totalPrice)
    {
        OrderId = orderId;
        CustomerName = customerName;
        TotalPrice = totalPrice;
    }

    public override string ToString()
    {
        return $"Order ID: {OrderId}, Customer: {CustomerName}, Total Price: {TotalPrice}";
    }
}

class Program
{
    static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice >
                    orders[j + 1].TotalPrice)
                {
                    Order temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    static int Partition(
        Order[] orders,
        int low,
        int high)
    {
        double pivot =
            orders[high].TotalPrice;

        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;

                Order temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        Order temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;

        return i + 1;
    }

    static void QuickSort(
        Order[] orders,
        int low,
        int high)
    {
        if (low < high)
        {
            int pi =
                Partition(
                    orders,
                    low,
                    high);

            QuickSort(
                orders,
                low,
                pi - 1);

            QuickSort(
                orders,
                pi + 1,
                high);
        }
    }

    static void Display(
        Order[] orders)
    {
        foreach (Order order in orders)
        {
            Console.WriteLine(order);
        }
    }

    static void Main()
    {
        Order[] orders =
        {
            new Order(
                101,
                "Rahul",
                5000),

            new Order(
                102,
                "Aman",
                2000),

            new Order(
                103,
                "Shreyansh",
                8000),

            new Order(
                104,
                "Priya",
                3000)
        };

        Console.WriteLine(
            "===== BUBBLE SORT =====\n");

        BubbleSort(orders);

        Display(orders);

        Order[] orders2 =
        {
            new Order(
                101,
                "Rahul",
                5000),

            new Order(
                102,
                "Aman",
                2000),

            new Order(
                103,
                "Shreyansh",
                8000),

            new Order(
                104,
                "Priya",
                3000)
        };

        Console.WriteLine(
            "\n===== QUICK SORT =====\n");

        QuickSort(
            orders2,
            0,
            orders2.Length - 1);

        Display(orders2);

        Console.WriteLine(
            "\n===== TIME COMPLEXITY =====");

        Console.WriteLine(
            "Bubble Sort : O(n²)");

        Console.WriteLine(
            "Quick Sort : O(n log n)");
    }
}