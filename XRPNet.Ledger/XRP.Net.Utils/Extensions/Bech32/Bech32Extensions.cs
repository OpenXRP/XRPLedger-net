namespace XRP.Net.Utils.Extensions.Bech32
{
    public static class Bech32Extensions
    {
        public static string GetBech32Address(string hrp, byte[] data)
        {
            return Bech32Engine.Encode(hrp, data);
        }
    }
}
