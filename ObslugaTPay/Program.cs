using ObslugaTPay.Api;
using ObslugaTPay.Helpers;
using ObslugaTPay.Logic;
using ObslugaTPay.Models;
using ObslugaTPay.Routes;
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
            #region config
            var origin = "https://secure.tpay.com";
            var apiKey = "75f86137a6635df826e3efe2e66f7c9a946fdde1";

            var credentials = new Credentials
            {
                Id = 1010,
                Code = "demo",
                CRC = "3214",
                Password = "p@$$w0rd#@!"
            };
            #endregion

            #region transaction
            var transactionRoutes = new RoutesGetter<TransactionRoutes>(new TransactionRoutes(origin, apiKey)).GetRoutesDictionary();
            var transaction = new Transaction(credentials, new TransactionApi(transactionRoutes)); 

            //CreateResponse createResponse = await transaction.CreateTransaction(new CreateData(100.99, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.TRUE)
            //{
            //    ExpirationDate = DateTime.Now.AddDays(3)
            //});

            //BlikResponse blikResponse = await transaction.PayViaBlik(createResponse, 123456);

            //ChargebackResponse chargebackResponse = await transaction.Chargeback(createResponse);

            //Console.WriteLine(chargebackResponse.Result);
            #endregion

            #region card
            var cardRoutes = new RoutesGetter<CardRoutes>(new CardRoutes(origin, apiKey)).GetRoutesDictionary();
            var cards = new Cards(credentials, new CardsApi(cardRoutes));
            #endregion
        }
    }
}
