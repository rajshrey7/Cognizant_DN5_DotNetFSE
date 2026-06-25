using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(double price);
}

class MobileApp : IObserver
{
    public void Update(double price)
    {
        Console.WriteLine(
            "Mobile App Notification : " + price);
    }
}

class WebApp : IObserver
{
    public void Update(double price)
    {
        Console.WriteLine(
            "Web App Notification    : " + price);
    }
}

class StockMarket
{
    private List<IObserver> observers =
        new List<IObserver>();

    private double price;

    public void Register(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(price);
        }
    }

    public void SetPrice(double price)
    {
        this.price = price;

        Console.WriteLine(
            "Stock Price Updated : " + price);

        NotifyObservers();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== OBSERVER PATTERN ==========\n");

        StockMarket stock =
            new StockMarket();

        stock.Register(new MobileApp());
        stock.Register(new WebApp());

        Console.WriteLine(
            "Updating Stock Price...\n");

        stock.SetPrice(500);

        Console.WriteLine(
            "\nAll observers notified.");

        Console.WriteLine(
            "\n======================================");
    }
}