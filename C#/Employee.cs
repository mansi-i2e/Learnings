class Employee
{
    public int salary;
    public string? empName;

    public Employee()                                   // deafult constructor
    {
        Console.WriteLine("Nothing to display");
    }

    public Employee(string name, int amount)              // parameterised constructor - takes params to initialise fields
    {
        salary = amount;
        empName = name;
        Console.WriteLine($"{name} has salary of {amount}");
    }

}