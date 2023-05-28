namespace MSschool.Application.Domain.Helpers;

internal static class DateTimeHelper
{
    internal static DateTimeOffset GetDateAndTime()
    {
        TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
        return TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, timeZoneInfo);
    }
}
