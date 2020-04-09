using ObslugaTPay.Api;
using ObslugaTPay.Helpers;
using ObslugaTPay.Logic;
using ObslugaTPay.Models;
using ObslugaTPay.Models.Enums;
using System;

namespace ObslugaTPay
{
    class Program
    {
        static void Main(string[] args)
        {
            Create();

            Console.ReadKey();
        }

        static async void Create()
        {

            var routes = new RoutesGetter(new RouteSetting("https://secure.tpay.com", "75f86137a6635df826e3efe2e66f7c9a946fdde1")).GetRoutesDictionary();
            var tpay = new Transaction(new Credentials
            {
                Id = 1010,
                Code = "demo",
                CRC = "3214",
                Password = "p@$$w0rd#@!"
            },
            new TransactionApi(routes)
            );  

            CreateResponse transaction = await tpay.CreateTransaction(new CreateData(100.99, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.TRUE)
            {
                ExpirationDate = DateTime.Now.AddDays(3)
            });

            BlikResponse blikResponse = await tpay.PayViaBlik(transaction, 123456);

            ChargebackResponse chargebackResponse = await tpay.Chargeback(transaction);

            Console.WriteLine(chargebackResponse.Result);

        }
    }
}
