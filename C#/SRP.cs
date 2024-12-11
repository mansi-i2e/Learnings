class Teacher
{
    public string? name { get; set; }
    public string? subject { get; set; }
}

class Display
{
    public void TeacherDetail(Teacher T)
    {
        Console.WriteLine($"{T.name} teaches the subject of {T.subject}");
    }
}