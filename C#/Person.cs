class Person
{
    public string FirstName = "Priya";
    public string LastName = "Shukla";
    public int age = 25;

    public void ShowInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} is {age} years old.");
    }
}