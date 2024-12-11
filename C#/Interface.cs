// used multiple interface to implement multiple inheritance as it cannot be implemented directly in C#

interface IStudInfo
{
    void showInfo(string name, int rollno, string house);
}
interface IStudMarks
{
    void showMarks(double marks, string sub);
}

class Student : IStudInfo, IStudMarks
{
    public void showInfo(string name, int rollno, string house)
    {
        Console.WriteLine("Here is the Student's info:");
        Console.WriteLine($"Student Name: {name}, RollNo: {rollno}, House: {house}");
    }
    public void showMarks(double marks, string sub)
    {
        Console.WriteLine($"Subject: {sub}, Score: {marks}");
    }
}