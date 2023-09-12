using System;

namespace XRP.Net.Utils.Extensions
{
    public static class HexExtensions
    {
        public static decimal GetDecimalFromHex(this string hexCode) => Convert.ToInt32(hexCode, 16);
        public static double GetDoubleFromHex(this string hexCode) => (double)Convert.ToInt32(hexCode, 16);
        public static string GetHexFromDouble(this double dbValue) => BitConverter.DoubleToInt64Bits(dbValue).ToString("X");
        public static string ToStringHex(this byte[] bytes)
        {
            var hex = BitConverter
                .ToString(bytes)
                .Replace("-", "")
                .ToLower();

            return hex;
        }
        public static string GetHexFromString(this byte[] data) => HexMate.Convert.ToHexString(data).ToUpper();
        private static char ToHexDigit(int i)
        {
            if (i < 10)
                return (char)(i + '0');
            return (char)(i - 10 + 'A');
        }
        public static string ToHexString(byte[] bytes)
        {
            var chars = new char[bytes.Length * 2 + 2];

            chars[0] = '0';
            chars[1] = 'x';

            for (int i = 0; i < bytes.Length; i++)
            {
                chars[2 * i + 2] = ToHexDigit(bytes[i] / 16);
                chars[2 * i + 3] = ToHexDigit(bytes[i] % 16);
            }

            return new string(chars);
        }
    }
}
