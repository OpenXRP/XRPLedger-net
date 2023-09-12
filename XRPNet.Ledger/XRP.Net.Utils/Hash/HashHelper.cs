using System.Security.Cryptography;
using XRP.Net.Utils.Extensions;

namespace XRP.Net.Utils.Hash
{
    public class HashHelper
    {
        public static string GetSha256(string data) => new Plugin.Security.Core.PasswordEncoder()
            .Encode(data, Plugin.Security.Core.EncryptType.SHA_256);

        public static string HashToHex(byte[] data)
        {
            return HexExtensions.GetHexFromString(Sha256(data));
        }


        public static byte[] Sha256(byte[] data)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return hash.ComputeHash((data));
            }
        }
    }
}
