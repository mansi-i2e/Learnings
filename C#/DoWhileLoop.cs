class DoWhileLoop
{
    public static int MySum(int n)
    {
        int sum = 0;
        int i = 1;
        do
        {
            sum += i;
            i++;
        } while (i <= n);
        return sum;
    }
}