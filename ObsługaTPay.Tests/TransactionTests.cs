using NUnit.Framework;
using ObslugaTPay.Helpers.Implementations;
using ObslugaTPay.Logic;
using ObslugaTPay.Models;
using FakeItEasy;
using ObslugaTPay.Helpers.Contracts;
using ObslugaTPay.Api;
using ObslugaTPay.Helpers;
using ObslugaTPay.Models.Enums;
using System.Threading.Tasks;
using Moq;

namespace ObslugaTPay.Tests
{
    public class TransactionTests
    {
        private Transaction _tpay;

        [SetUp]
        public void Setup()
        {
            var mock = new Mock<ITransactionsApi>();
            mock.Setup(m => m.Create(new Create())).Returns(default(Task<CreateResponse>));

            ITransactionsApi api = mock.Object;
            var routes = new RoutesGetter(new RouteSetting("https://secure.tpay.com", "75f86137a6635df826e3efe2e66f7c9a946fdde1")).GetRoutesDictionary();
            _tpay = new Transaction(new Credentials
            {
                Id = 1010,
                Code = "demo",
                CRC = "3214",
                Password = "p@$$w0rd#@!"
            },
            api
            );
        }

        [Test]
        public void CreateTransactionShouldPass()
        {
            Task.Run(async () =>
            {
                var result = await _tpay.CreateTransaction(new CreateData(100.99, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.TRUE));
                Assert.IsNotNull(result);

            }).GetAwaiter().GetResult();
        }
    }
}
