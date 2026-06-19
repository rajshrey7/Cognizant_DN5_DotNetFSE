using System;

class Computer
{
    private string cpu;
    private int ram;
    private int storage;

    private Computer(Builder builder)
    {
        cpu = builder.CPU;
        ram = builder.RAM;
        storage = builder.Storage;
    }

    public void Show()
    {
        Console.WriteLine("CPU     : " + cpu);
        Console.WriteLine("RAM     : " + ram + " GB");
        Console.WriteLine("Storage : " + storage + " GB");
    }

    public class Builder
    {
        public string CPU;
        public int RAM;
        public int Storage;

        public Builder SetCPU(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Builder SetRAM(int ram)
        {
            RAM = ram;
            return this;
        }

        public Builder SetStorage(int storage)
        {
            Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("========== BUILDER PATTERN ==========\n");

        Computer pc = new Computer.Builder()
            .SetCPU("Intel i7")
            .SetRAM(16)
            .SetStorage(512)
            .Build();

        Console.WriteLine("Computer Built Successfully\n");

        pc.Show();

        Console.WriteLine("\n=====================================");
    }
}