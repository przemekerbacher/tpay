using NUnit.Framework;
using ObslugaTPay.Logic;
using ObslugaTPay.Models;
using ObslugaTPay.Api;
using ObslugaTPay.Helpers;
using ObslugaTPay.Models.Enums;
using System.Threading.Tasks;
using ObslugaTPay.Routes;

namespace ObslugaTPay.Tests
{
    //If everything failed, check internet connection.
    public class TransactionTests
    {
        private Transaction _tpay;

        [SetUp]
        public void Setup()
        {
            var origin = "https://secure.tpay.com";
            var transactionApiKey = "75f86137a6635df826e3efe2e66f7c9a946fdde1";
            var credentials = new TransactionCredentials
            {
                Id = 1010,
                Code = "demo",
                CRC = "3214",
                Password = "p@$$w0rd#@!"
            };
            var transactionRoutes = new RoutesGetter<TransactionRoutes>(new TransactionRoutes(origin, transactionApiKey)).GetRoutesDictionary();

           _tpay = new Transaction(credentials, new TransactionApi(transactionRoutes));
        }

        [Test]
        public async Task CreateTransactionShouldPass()
        {
            CreateResponse createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.True));

            Assert.IsNotNull( createResponse.Title);
        }

        [Test]
        public async Task CreateTransactionWithInvalidBankGroupShouldReturnNull()
        {
            CreateResponse createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 100, "Jan Kowalski", AcceptTos.True));

            Assert.IsNull(createResponse.Title);
        }

        [Test]
        public async Task BlikPaymentShouldPass()
        {
            var createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.True));
            var blikResult = await _tpay.PayUsingBlik(createResponse, 123456);
            
            Assert.That(blikResult.Result == Result.Succes);
        }

        [Test]
        public async Task BlikPaymentWithBadCodeShouldReturnNull()
        {
            var createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.True));
            var blikResult = await _tpay.PayUsingBlik(createResponse, 1234556);

            Assert.That(blikResult, Is.Null);
        }

        [Test]
        public async Task BlikPaymentWithadBankGroupShouldFail()
        {
            var createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 102, "Jan Kowalski", AcceptTos.True));
            var blikResult = await _tpay.PayUsingBlik(createResponse, 1234556);

            Assert.That(blikResult, Is.Null);
        }

        [Test]
        public async Task RefundTransactionShouldNotBeNull()
        {
            var createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 102, "Jan Kowalski", AcceptTos.True));

            var refund = await _tpay.Chargeback(createResponse);

            Assert.That(refund, Is.Not.Null);
        }

        [Test]
        public async Task GetShouldPass()
        {
            var createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 102, "Jan Kowalski", AcceptTos.True));
            var getResponse = await _tpay.Get(createResponse);

            Assert.That(getResponse, Is.Not.Null);
        }
    }
}
