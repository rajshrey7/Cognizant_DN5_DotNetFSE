using System;

interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}

class PayPalGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("PayPal Payment : ₹" + amount);
    }
}

class PayPalAdapter : IPaymentProcessor
{
    private PayPalGateway gateway = new PayPalGateway();

    public void ProcessPayment(double amount)
    {
        gateway.MakePayment(amount);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("========== ADAPTER PATTERN ==========\n");

        IPaymentProcessor processor =
            new PayPalAdapter();

        Console.WriteLine("Processing Payment...\n");

        processor.ProcessPayment(1000);

        Console.WriteLine(
            "\nPayment Completed Successfully.");

        Console.WriteLine(
            "\n=====================================");
    }
}