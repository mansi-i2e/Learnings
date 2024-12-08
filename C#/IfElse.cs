class IfElse
{
    public static string showDetail(int age)
    {
        if (age < 13)
        {
            return "You are still a kid and not allowed to play this game";
        }
        else if (age > 13 && age < 50)
        {
            return "You can play this game";
        }
        else
        {
            return "You cannot play this game";
        }
    }
}