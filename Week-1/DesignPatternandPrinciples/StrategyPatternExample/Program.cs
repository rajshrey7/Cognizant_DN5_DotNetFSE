using System;

interface IPaymentStrategy
{
    void Pay(int amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine(
            "Amount Paid : " + amount);
    }
}

class PayPalPayment : IPaymentStrategy
{
    public void Pay(int amount)
    {
        Console.WriteLine(
            "Amount Paid : " + amount);
    }
}

class PaymentContext
{
    private IPaymentStrategy strategy;

    public PaymentContext(
        IPaymentStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void Execute(int amount)
    {
        strategy.Pay(amount);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== STRATEGY PATTERN ==========\n");

        Console.WriteLine(
            "Payment Method : Credit Card");

        new PaymentContext(
            new CreditCardPayment())
            .Execute(1000);

        Console.WriteLine();

        Console.WriteLine(
            "Payment Method : PayPal");

        new PaymentContext(
            new PayPalPayment())
            .Execute(2000);

        Console.WriteLine(
            "\n======================================");
    }
}