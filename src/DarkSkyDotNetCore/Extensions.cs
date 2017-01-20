using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkSkyDotNetCore
{
    public static class Extensions
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ToDateTime(this Int64 _input)
        {
            return UnixEpoch.AddSeconds(_input);
        }

        public static string ToUTCString(this DateTime _input)
        {
            var milliseconds = _input.ToUniversalTime().Subtract(UnixEpoch).TotalSeconds;
            return Convert.ToInt64(milliseconds).ToString();
        }

        public static string ToPercentString(this float value)
        {
            var percentValue = value * 100;
            return $"{percentValue}%";
        }

        public static int ToWholeNumber(this float value)
        {
            return (int)Math.Round((decimal)value, 0);
        }
    }
}
