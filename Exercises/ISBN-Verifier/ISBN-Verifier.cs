/*
 Instructions
The ISBN-10 verification process is used to validate book identification numbers. 
These normally contain dashes and look like: 3-598-21508-8

ISBN
The ISBN-10 format is 9 digits (0 to 9) plus one check character (either a digit or an X only). 
In the case the check character is an X, this represents the value '10'. 
These may be communicated with or without hyphens, and can be checked for their validity by the following formula:

(d₁ * 10 + d₂ * 9 + d₃ * 8 + d₄ * 7 + d₅ * 6 + d₆ * 5 + d₇ * 4 + d₈ * 3 + d₉ * 2 + d₁₀ * 1) mod 11 == 0
If the result is 0, then it is a valid ISBN-10, otherwise it is invalid.
 
 */
using System;
using System.Text.RegularExpressions;

namespace Exercism_Exercises.Exercises.ISBNVerifier;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        //Remove the dashes
        number = number.ToUpper().Replace("-", "");

        //Check if structure is correct
        if (!Regex.IsMatch(input: number, pattern: @$"^[0-9]{{9}}([0-9]|X)$"))
            return false;

        //Validate ISBN
        //(d₁ *10 + d₂ *9 + d₃ *8 + d₄ *7 + d₅ *6 + d₆ *5 + d₇ *4 + d₈ *3 + d₉ *2 + d₁₀ *1) mod 11 == 0
        int res = 0;
        for (int i = 0; i < 10; i++)
        {
            int x = (number[i] == 'X') ? 10 : Convert.ToInt16(number[i].ToString());
            res += x * (10 - i);
        }

        return res % 11 == 0;
    }
}
//Made by ericssonGamerz4

