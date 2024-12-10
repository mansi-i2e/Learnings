class MethodOverload           // multiple method with same name, but diff no/type of param
{
    public static int Area(int s)   // square
    {
        return s * s;
    }

    public static double Area(double r)   // circle
    {
        return 3.14 * r * r;
    }

    public static int Area(int l, int b)   // rectangle
    {
        return l * b;
    }

    public static double Area(double b, double h)   // triangle
    {
        return 0.5 * b * h;
    }
}