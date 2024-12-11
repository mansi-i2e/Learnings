class Number
{
    public static void checkEven(int n)
    {
        if (n % 2 != 0)
        {
            throw new ArithmeticException("Number is ODD");
        }
        else
        {
            Console.WriteLine("EVEN NUMBER");
        }
    }
}