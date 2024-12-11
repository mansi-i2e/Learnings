public abstract class Add
{
    public abstract void Addition();
}

public class IntAdd : Add
{
    public int num1 { get; set; }
    public int num2 { get; set; }

    public override void Addition()
    {
        Console.WriteLine($"Addition operation: {num1 + num2}");
    }
}

public class StrAdd : Add
{
    public string? str1 { get; set; }
    public string? str2 { get; set; }

    public override void Addition()
    {
        Console.WriteLine($"Addition operation: {str1 + str2}");
    }
}

public class DoubleAdd : Add
{
    public double num1 { get; set; }
    public double num2 { get; set; }

    public override void Addition()
    {
        Console.WriteLine($"Addition operation: {num1 + num2}");
    }
}
