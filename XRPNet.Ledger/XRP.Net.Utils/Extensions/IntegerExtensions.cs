using System;
using System.Linq;

namespace XRP.Net.Utils.Extensions
{
    public static class IntegerExtensions
    {
        public static byte[] ConvertFromIntArray(this Int32[] data) => data.SelectMany(BitConverter.GetBytes).ToArray();
        public static Int32[] ConvertToInt32Array(this byte[] data) => data.Select(w => Convert.ToInt32(w)).ToArray();
    }
}
