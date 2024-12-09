class Switch
{

    public static string ShowDays(int days)
    {
        switch (days)
        {
            case 1:
                return "It's Monday";


            case 2:
                return "It's Tuesday";


            case 3:
                return "It's Wednesday";


            case 4:
                return "It's Thursday";


            case 5:
                return "It's Friday";


            case 6:
                return "It's Saturday";


            case 7:
                return "It's Sunday";


            default:
                return "Invalid day";

        }
    }
}