using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    private static (TimeZoneInfo timeZoneInfo, CultureInfo cultureInfo) GetTimeZoneInfo(Location location)
    {
        bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        return location switch
        {
            Location.NewYork => (isWindows ? TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time") : TimeZoneInfo.FindSystemTimeZoneById("America/New_York"), new CultureInfo("en-US")),
            Location.London => (isWindows ? TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time") : TimeZoneInfo.FindSystemTimeZoneById("Europe/London"), new CultureInfo("en-GB")),
            Location.Paris => (isWindows ? TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time") : TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris"), new CultureInfo("fr-FR")),
            _ => throw new ArgumentException($"The location {location} is not valid."),
        };
    }
    public static DateTime Schedule(string appointmentDateDescription, Location location) => TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), GetTimeZoneInfo(location).timeZoneInfo);

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
        AlertLevel.Late => appointment.AddMinutes(-30),
        _ => throw new ArgumentException($"The alert level {alertLevel} is not valid."),
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location) => GetTimeZoneInfo(location).timeZoneInfo.IsDaylightSavingTime(dt) != GetTimeZoneInfo(location).timeZoneInfo.IsDaylightSavingTime(dt.AddDays(-7));

    public static DateTime NormalizeDateTime(string dtStr, Location location) => DateTime.TryParse(dtStr, GetTimeZoneInfo(location).cultureInfo, DateTimeStyles.AssumeLocal, out var date) ? date : DateTime.MinValue;
}
