using System;

class Employee
{
    public int EmployeeId;
    public string Name;
    public string Position;
    public double Salary;

    public Employee(int employeeId,
                    string name,
                    string position,
                    double salary)
    {
        EmployeeId = employeeId;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {Name}, Position: {Position}, Salary: {Salary}";
    }
}

class Program
{
    static Employee[] employees =
        new Employee[10];

    static int count = 0;

    static void AddEmployee(Employee employee)
    {
        employees[count++] = employee;

        Console.WriteLine(
            "Employee Added Successfully");
    }

    static Employee SearchEmployee(
        int employeeId)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId ==
                employeeId)
            {
                return employees[i];
            }
        }

        return null;
    }

    static void DeleteEmployee(
        int employeeId)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId ==
                employeeId)
            {
                for (int j = i;
                     j < count - 1;
                     j++)
                {
                    employees[j] =
                        employees[j + 1];
                }

                count--;

                Console.WriteLine(
                    "Employee Deleted Successfully");

                return;
            }
        }
    }

    static void DisplayEmployees()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                employees[i]);
        }
    }

    static void Main()
    {
        Console.WriteLine(
            "===== ADD EMPLOYEES =====\n");

        AddEmployee(
            new Employee(
                101,
                "Rahul",
                "Developer",
                50000));

        AddEmployee(
            new Employee(
                102,
                "Shreyansh",
                "Tester",
                40000));

        Console.WriteLine(
            "\n===== EMPLOYEE LIST =====\n");

        DisplayEmployees();

        Console.WriteLine(
            "\n===== SEARCH EMPLOYEE =====\n");

        Console.WriteLine(
            SearchEmployee(102));

        Console.WriteLine(
            "\n===== DELETE EMPLOYEE =====\n");

        DeleteEmployee(101);

        Console.WriteLine(
            "\n===== FINAL EMPLOYEE LIST =====\n");

        DisplayEmployees();

        Console.WriteLine(
            "\n===== TIME COMPLEXITY =====");

        Console.WriteLine(
            "Add      : O(1)");

        Console.WriteLine(
            "Search   : O(n)");

        Console.WriteLine(
            "Traverse : O(n)");

        Console.WriteLine(
            "Delete   : O(n)");
    }
}