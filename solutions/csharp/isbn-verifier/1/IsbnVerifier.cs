using System.Text.RegularExpressions;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        //Remove the dashes
        number = number.ToUpper().Replace("-", "");

        //Check if structure is correct
        if (!CheckValidStructure(number))
            return false;

        //Validate ISBN
        int res = 0;
        for (int i = 0; i < 10; i++)
        {
            int x = (number[i] == 'X') ? 10 : Convert.ToInt16(number[i].ToString());
            res += x * (10 - i);
        }

        return res % 11 == 0;
    }

    private static bool CheckValidStructure(string number) => Regex.IsMatch(input: number, pattern: @$"^[0-9]{{9}}([0-9]|X)$");


}
//Made by ericssonGamerz4
