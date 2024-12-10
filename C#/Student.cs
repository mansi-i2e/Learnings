class Student
{
    public string FirstName = "Priya";
    public string LastName = "Shukla";
    public double CGPA = 8.54;

    public void ShowInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} has scored {CGPA} cgpa");
    }
}