using Castle.Core.Logging;
using Flurl;
using ObslugaTPay.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Create = ObslugaTPay.Models.Create;

namespace ObslugaTPay.Api
{
    public class TPayApiAccess : ITPayApiAccess
    {
        private IDictionary<string, string> _routes;
        private string _create = "CreateUrl";
        private string _blik = "CreateUrl";
        private string _chargeback = "ChargebackUrl";
        private string _chargebackAny = "ChargebackAny";
        private string _get = "GetUrl";
        private string _refund = "RefundUrl";
        public TPayApiAccess(IDictionary<string, string> routes)
        {
            _routes = routes;
        }

        public async Task<BlikResponse> BlikPayment(Blik data)
        {
            var url = _routes[_blik];

            var sender = new Sender<Blik, BlikResponse>();
            return await sender.Post(data, url);
        }

        public async Task<ChargebackResponse> Chargeback(Chargeback data)
        {
            var url = _routes[_chargeback];

            var sender = new Sender<Chargeback, ChargebackResponse>();
            return await sender.Post(data, url);
        }

        public async Task<ChargebackResponse> ChargebackAny(Chargeback data)
        {
            var url = _routes[_chargebackAny];

            var sender = new Sender<Chargeback, ChargebackResponse>();
            return await sender.Post(data, url);
        }

        public async Task<CreateResponse> Create(Create data)
        {
            var url = _routes[_create]; 

            var sender = new Sender<Create, CreateResponse>();

            return await sender.Post(data, url);
        }

        public async Task<GetResponse> Get(Get data)
        {
            var url = _routes[_get];

            var sender = new Sender<Get, GetResponse>();
            return await sender.Post(data, url);
        }

        public async Task<RefundTransactionRespose>
            GetChargebackStatus(RefundTransaction data)
        {

            var url = _routes[_refund];

            var sender = new Sender<RefundTransaction, RefundTransactionRespose>();
            return await sender.Post(data, url); ;
        }
    }
}
