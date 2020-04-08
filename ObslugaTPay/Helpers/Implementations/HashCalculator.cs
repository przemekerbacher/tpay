using ObslugaTPay.Helpers.Contracts;
using System.Security.Cryptography;
using System.Text;

namespace ObslugaTPay.Helpers.Implementations
{
    public class HashCalculator : IHashCalculator
    {
        public string Md5Sum(string id, string amount, string crc, string code)
        {
            var data = id + amount + crc + code;

            return Calculate(data);
        }

        public string TimeHash(string expirationDate, string code)
        {
            var data = expirationDate + code;

            return Calculate(data);
        }

        private string Calculate(string data)
        {
            var md5Hash = MD5.Create();
            var md5Bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(data));
            var stringBuilder = new StringBuilder();

            foreach (var singleData in md5Bytes)
            {
                stringBuilder.Append(singleData.ToString("x2"));
            }


            return stringBuilder.ToString();
        }
    }
}
