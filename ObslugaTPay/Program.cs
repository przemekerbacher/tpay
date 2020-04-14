using ObslugaTPay.Api;
using ObslugaTPay.Helpers;
using ObslugaTPay.Logic;
using ObslugaTPay.Models;
using ObslugaTPay.Models.Enums;
using ObslugaTPay.Routes;
using System;
using System.Threading.Tasks;

namespace ObslugaTPay
{
    class Program
    {
        static Transaction _tpay;

        static void Main(string[] args)
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

            Create();

            Console.ReadKey();
        }

        static async Task Create()
        {
            CreateResponse createResponse = await _tpay.CreateTransaction(new CreateData((float)100, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.True));

        }
    }
}
