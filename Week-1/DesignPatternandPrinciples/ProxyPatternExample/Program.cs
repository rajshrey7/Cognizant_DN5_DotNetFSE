using System;

interface IImage
{
    void Display();
}

class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;

        Console.WriteLine(
            "Loading " + fileName);
    }

    public void Display()
    {
        Console.WriteLine(
            "Displaying " + fileName);
    }
}

class ProxyImage : IImage
{
    private RealImage realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage =
                new RealImage(fileName);
        }

        realImage.Display();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== PROXY PATTERN ==========\n");

        IImage image =
            new ProxyImage("photo.jpg");

        Console.WriteLine(
            "First Access:");

        image.Display();

        Console.WriteLine(
            "\nSecond Access:");

        image.Display();

        Console.WriteLine(
            "\nImage loaded only once.");

        Console.WriteLine(
            "\n===================================");
    }
}