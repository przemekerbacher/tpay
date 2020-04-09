using ObslugaTPay.Api;
using ObslugaTPay.Helpers.Implementations;
using ObslugaTPay.Models;
using System.Globalization;
using System.Threading.Tasks;

namespace ObslugaTPay.Logic
{
    public class Transaction : ApiData
    {
        public bool AllowChargebackAny { get; set; } = false;

        private ITransactionsApi _api;

        public Transaction(Credentials credentials, ITransactionsApi api) : base(credentials)
        {
            _api = api;
            _credentials = credentials;
        }

        public async Task<CreateResponse> CreateTransaction(CreateData model)
        {
            var hashCalculator = new HashCalculator();
            var md5Sum = hashCalculator.Md5Sum(_credentials.Id.ToString(), model.Amount.ToString(CultureInfo.InvariantCulture), _credentials.CRC, _credentials.Code);
            var timeHash = hashCalculator.TimeHash(model.ExpirationDate.Value.ToString(DateTimeFormat), _credentials.Code);

            var secrets = new Secrets
            {
                Md5sum = md5Sum,
                TimeHash = timeHash,
                CRC = _credentials.CRC,
                Id = _credentials.Id,
                Password = _credentials.Password
            };

            return await _api.Create(new Create
            {
                Id = secrets.Id,
                CRC = secrets.CRC,
                TimeHash = secrets.TimeHash,
                Md5sum = secrets.Md5sum,
                ApiPassword = secrets.Password,
                AcceptTos = model.AcceptTos,
                Address = model.Address,
                Amount = model.Amount,
                City = model.City,
                Country = model.Country,
                CustomDescription = model.CustomDescription,
                Description = model.Description,
                Email = model.Email,
                ExprationDate = model.ExpirationDate.Value.ToString(DateTimeFormat),
                Group = model.Group,
                Language = model.Language,
                MerchantDescription = model.MerchantDescription,
                Name = model.Name,
                Online = model.Online,
                Phone = model.Phone,
                ResultEmail = model.ResultEmail,
                ResultUrl = model.ResultUrl,
                ReturnErrorUrl = model.ReturnErrorUrl,
                ReturnUrl = model.ReturnUrl,
                Zip = model.Zip,
            });
        }

        public async Task<BlikResponse> PayViaBlik(CreateResponse model, int code)
        {
            if (model != null)
            {

                return await _api.BlikPayment(new Blik
                {
                    Code = code,
                    Title = model.Title,
                    ApiPassword = _credentials.Password,
                });
            }

            return null;

        }

        public async Task<GetResponse> Get(CreateResponse model)
        {
            if (model != null)
            {
                return await _api.Get(new Get { Title = model.Title, ApiPassword = _credentials.Password });
            }

            return null;

        }

        public async Task<BlikResponse> Blik(CreateResponse model, Alias alias, int? code = null)
        {
            if (model != null)
            {
                return await _api.BlikPayment(new Blik
                {
                    Code = code,
                    Title = model.Title,
                    ApiPassword = _credentials.Password,
                    Alias = alias
                });
            }

            return null;
        }

        public async Task<ChargebackResponse> Chargeback(CreateResponse model)
        {
            if (model != null)
            {
                return await _api.Chargeback(new Chargeback
                {
                    Title = model.Title,
                    ApiPassword = _credentials.Password
                }); ;
            }

            return null;
        }

        public async Task<ChargebackResponse> ChargebackAny(CreateResponse model, float amount)
        {
            if (AllowChargebackAny && model != null)
            {
                return await _api.ChargebackAny(new ChargebackAny
                {
                    Title = model.Title,
                    ApiPassword = _credentials.Password,
                    Amount = amount

                });
            }

            return null;
        }

        public async Task<RefundTransactionRespose> GetChargebackStatus(CreateResponse model)
        {
            if (model != null)
            {
                return await _api.GetChargebackStatus(new RefundTransaction
                {
                    Title = model.Title,
                    Password = _credentials.Password
                });
            }

            return null;
        }
    }
}
