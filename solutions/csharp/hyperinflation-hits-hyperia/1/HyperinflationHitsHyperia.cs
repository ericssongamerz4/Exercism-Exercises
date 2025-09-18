using System;


public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            return $"{checked(@base * multiplier)}";
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {

        float result = @base * multiplier;
        if (float.IsInfinity(result))
            return "*** Too Big ***";

        return $"{result}";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            return $"{salaryBase * multiplier}";
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}


//Made by ericssonGamerz4

