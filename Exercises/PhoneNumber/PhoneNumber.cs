using System.Text.RegularExpressions;

namespace Exercism_Exercises.Exercises.PhoneNumber;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleanPhoneNumber = GetNumbersFromString(phoneNumber);

        if(!IsNumberValid(cleanPhoneNumber,out string res))
           throw new ArgumentException();

        return res;
    }
    private static string GetNumbersFromString(string phoneNumber) => Regex.Replace(phoneNumber, @"[^\d]", "");
    private static bool IsNumberValid(string cleanPhoneNumber, out string finalPhoneNumber)
    {
        cleanPhoneNumber = Regex.Replace(cleanPhoneNumber,"^1",string.Empty);

        string n = @"[2-9]";
        string x = @"[0-9]";

        bool isValid = Regex.IsMatch(cleanPhoneNumber,$"{n}{x}{x}{n}{x}{x}{x}{x}{x}{x}");

        finalPhoneNumber = cleanPhoneNumber;

        if (cleanPhoneNumber.Length != 10)
            return false;

        return isValid;
    }
}
//Made by ericssonGamerz4          