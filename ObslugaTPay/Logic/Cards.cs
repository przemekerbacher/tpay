using ObslugaTPay.Api;
using ObslugaTPay.Models;

namespace ObslugaTPay.Logic
{
    public class Cards
    {
        private CardsApi _api;

        public Cards(Credentials credentials, CardsApi api) 
        {
            _api = api;
        }
    }
}
