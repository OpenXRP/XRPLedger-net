using System.IO;
using System.Text;

namespace XRP.Net.Utils.Extensions
{
    public static class XRPStringExtensions
    {
        public static bool ContainsIgnoreCase(this string source, string verify) => source.ToLower().Contains(verify.ToLower());

        public static string GetStringOrDefault(this string result, string defaultString = "Unknown") => string.IsNullOrWhiteSpace(result) ? defaultString : result;

        public static string GenerateCleanStringFromAscii(this string result)
        {
            return Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8,
                Encoding.GetEncoding(
                    Encoding.ASCII.EncodingName,
                    new EncoderReplacementFallback(string.Empty),
                    new DecoderExceptionFallback()
                    ),

                Encoding.UTF8.GetBytes(result)));
        }

        public static string GetStringFromStream(Stream memoryStream) => new StreamReader(memoryStream).ReadToEnd();
        public static byte[] GetBytesFromString(string text) => Encoding.UTF8.GetBytes(text);
        public static string GetStringFromBase64(string base64) => GetStringFromBytes(System.Convert.FromBase64String(base64));
        public static byte[] GetBytesFromBase64(string base64) => System.Convert.FromBase64String(base64);

        public static string GetJSONFromobject(object data) => Newtonsoft.Json.JsonConvert.SerializeObject(data);
        public static string EscapeSingleQuotes(string str) => str.Replace("/g,", "\\");
        public static string GetBase64FromString(string text) => System.Convert.ToBase64String(GetBytesFromString(text));
        public static byte[] GetBase64BytesFromString(string text) => GetBytesFromString(GetBase64FromString(text));
        public static byte[] GetBase64BytesFromBytes(byte[] data) => GetBytesFromString(GetBase64FromBytes(data));
        public static string GetBase64FromBytes(byte[] data) => System.Convert.ToBase64String(data);
        public static string GetStringFromBytes(byte[] data) => System.Text.Encoding.UTF8.GetString(data);
    }

}
