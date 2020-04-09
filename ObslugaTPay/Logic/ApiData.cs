using ObslugaTPay.Api;
using ObslugaTPay.Models;

namespace ObslugaTPay.Logic
{
    public class ApiData
    {
        public string DateTimeFormat = "yyyy:MM:dd:HH:MM";

        protected Credentials _credentials;

        public ApiData(Credentials credentials)
        {

        }
    }
}
