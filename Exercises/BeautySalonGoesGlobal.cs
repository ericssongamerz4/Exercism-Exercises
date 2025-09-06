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

    private static TimeZoneInfo GetTimeZoneInfo(Location location) => location switch
    {
        Location.NewYork => IsWindows() ? TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time") : TimeZoneInfo.FindSystemTimeZoneById("America/New_York"),
        Location.London => IsWindows() ? TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time") : TimeZoneInfo.FindSystemTimeZoneById("Europe/London"),
        Location.Paris => IsWindows() ? TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time") : TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris"),
        _ => throw new ArgumentException($"The location {location} is not valid."),
    };
    private static CultureInfo GetCultureInfo(Location location) => location switch
    {
        Location.NewYork => new CultureInfo("en-US"),
        Location.London => new CultureInfo("en-GB"),
        Location.Paris => new CultureInfo("fr-FR"),
        _ => throw new ArgumentException($"The location {location} is not valid."),
    };

    private static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

    public static DateTime Schedule(string appointmentDateDescription, Location location) => TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), GetTimeZoneInfo(location));

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
        AlertLevel.Late => appointment.AddMinutes(-30),
        _ => throw new ArgumentException($"The alert level {alertLevel} is not valid."),
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location) => GetTimeZoneInfo(location).IsDaylightSavingTime(dt) != GetTimeZoneInfo(location).IsDaylightSavingTime(dt.AddDays(-7));

    public static DateTime NormalizeDateTime(string dtStr, Location location) => DateTime.TryParse(dtStr, GetCultureInfo(location), out var date) ? date : DateTime.MinValue;
}
