class ForLoop
{
    public static int ShowSum(int n)
    {        // sum of n natural numbers
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}