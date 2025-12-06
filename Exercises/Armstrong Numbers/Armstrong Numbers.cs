using System;

namespace Exercism_Exercises.Exercises.ArmstrongNumbers;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int originalNumber)
    {
        int result = 0;
        string number = originalNumber.ToString();

        foreach (char digit in number)        
            result += (int)Math.Pow(Convert.ToInt32(digit.ToString()), number.Length);
        

        return result == originalNumber;
    }
}
//Made by ericssonGamerz4