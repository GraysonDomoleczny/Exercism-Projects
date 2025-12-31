using System.Runtime.InteropServices;
using System.Globalization;

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
    private static TimeZoneInfo GetTimeZone(Location location)
    {
        bool IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        return (location, IsWindows) switch
        {
            (Location.NewYork, true) => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            (Location.London, true) => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
            (Location.Paris, true) => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
            (Location.NewYork, false) => TimeZoneInfo.FindSystemTimeZoneById("America/New_York"),
            (Location.London, false) => TimeZoneInfo.FindSystemTimeZoneById("Europe/London"),
            (Location.Paris, false) => TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris")
        };
    }
        
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location) =>
        TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), GetTimeZone(location));

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) =>
        alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.AddMinutes(-105),
            AlertLevel.Late => appointment.AddMinutes(-30)
        };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZone = GetTimeZone(location);
    
        return timeZone.IsDaylightSavingTime(TimeZoneInfo.ConvertTimeFromUtc(dt, timeZone)) !=
               timeZone.IsDaylightSavingTime(TimeZoneInfo.ConvertTimeFromUtc(dt.AddDays(-7), timeZone));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture = location switch 
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR")
        };

        return DateTime.TryParse(dtStr, culture, out DateTime dt) ? dt : DateTime.MinValue;
    }         
}
