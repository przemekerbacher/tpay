using ObslugaTPay.Helpers;
using ObslugaTPay.Helpers.Contracts;
using ObslugaTPay.Models;
using System.Threading.Tasks;
using Create = ObslugaTPay.Models.Create;

namespace ObslugaTPay.Api
{
    public class TPayApiAccess
    {
        private Routes _routes;
        private ISerializer _serializer;

        public TPayApiAccess(Routes routes)
        {
            _routes = routes;
            _serializer = new CustomJsonSerializer();
        }

        public async Task<BlikResponse> BlikPayment(Blik data)
        {
            var url = _routes.Blik;
            var sender = new Sender<Blik, BlikResponse>();
            return await sender.Post(data, url);
        }

        public async Task<ChargebackResponse> Chargeback(Chargeback data)
        {
            var url = _routes.Chargeback;
            var sender = new Sender<Chargeback, ChargebackResponse>();

            return await sender.Post(data, url);
        }

        public async Task<ChargebackResponse> ChargebackAny(Chargeback data)
        {
            var url = _routes.ChargebackAny;

            var sender = new Sender<Chargeback, ChargebackResponse>();
            return await sender.Post(data, url);
        }

        public async Task<CreateResponse> Create(Create data)
        {
            var url = _routes.Create;
            var sender = new Sender<Create, CreateResponse>();

            return await sender.Post(data, url);
        }

        public async Task<GetResponse> Get(Get data)
        {
            var url = _routes.Get;

            var sender = new Sender<Get, GetResponse>();
            return await sender.Post(data, url);
        }
    }
}
