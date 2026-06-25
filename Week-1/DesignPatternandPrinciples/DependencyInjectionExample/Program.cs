using System;

interface ICustomerRepository
{
    string FindCustomerById(int id);
}

class CustomerRepositoryImpl : ICustomerRepository
{
    public string FindCustomerById(int id)
    {
        return "Customer ID : " + id;
    }
}

class CustomerService
{
    private ICustomerRepository repository;

    public CustomerService(
        ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        Console.WriteLine(
            repository.FindCustomerById(id));
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(
            "========== DEPENDENCY INJECTION PATTERN ==========\n");

        ICustomerRepository repository =
            new CustomerRepositoryImpl();

        CustomerService service =
            new CustomerService(repository);

        Console.WriteLine(
            "Fetching Customer Details...\n");

        service.GetCustomer(101);

        Console.WriteLine(
            "\nRepository injected successfully.");

        Console.WriteLine(
            "\n=================================================");
    }
}