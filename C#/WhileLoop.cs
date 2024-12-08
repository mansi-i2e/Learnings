class WhileLoop
{
    public static int GetSum(int n)
    {
        int sum = 0;
        int i = 1;
        while (i <= n)
        {
            sum += i;
            i++;
        }
        return sum;
    }
}