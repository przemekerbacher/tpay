using System.Security.Cryptography;

namespace ObslugaTPay.Models
{
    public class Secrets
    {
        public int Id { get; set; }
        public string CRC { get; set; }
        public string Md5sum { get; set; }
        public string TimeHash { get; set; }
        public string Password { get; set; }
    }
}
