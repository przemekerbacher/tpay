namespace ObslugaTPay.Models
{
    public class Credentials
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ApiKey { get; set; }
        public string Password { get; set; }
        public string CRC { get; set; }
    }
}
