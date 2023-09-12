
using System;

namespace XRP.Net.Utils.Extensions
{
    public static class DateTimeExtensions
    {
        private const string ISO_REGEX = "/\\.000Z$/";
        public static DateTime GetISODateTimeFromString(this string dateTime)
        {
            return DateTime.Parse(dateTime);
        }
        public static string GetISOStringFromDate(this DateTime date)
        {
            return date.ToString("s").Replace(ISO_REGEX, "Z");
        }
    }

}
