using System.Text.RegularExpressions;

namespace Exercism_Exercises.Exercises.PhoneNumber;

public class PhoneNumber
{
    private const string CountryCodePattern = @"1?";
    private const string AreaCodePattern = @"(?<areacode>[2-9]\d{2})";
    private const string ExchangeCodePattern = @"(?<exchangecode>[2-9]\d{2})";
    private const string SubscriberNumberPattern = @"(?<subscribernumber>\d{4})";
    private const string NonDigitPattern = @"[^\d]*?";
    private const string PhoneNumberPattern = $"^{NonDigitPattern}{CountryCodePattern}{NonDigitPattern}{AreaCodePattern}{NonDigitPattern}{ExchangeCodePattern}{NonDigitPattern}{SubscriberNumberPattern}{NonDigitPattern}$";
    //private const string PhoneNumberPattern = @"^[^\d]*?1?[^\d]*?([2-9]\d{2})[^\d]*?([2-9]\d{2})[^\d]*?(\d{4})[^\d]*$";

    public static string Clean(string phoneNumber)
    {
        var match = Regex.Match(phoneNumber, PhoneNumberPattern);

        if (!match.Success)
            throw new ArgumentException("Invalid phone number", nameof(phoneNumber));

        return $"{match.Groups[1].Value}{match.Groups[2].Value}{match.Groups[3].Value}";
    }
}
//Made by ericssonGamerz4          