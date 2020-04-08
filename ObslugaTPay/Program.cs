using ObslugaTPay.Api;
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
            var tpay = new TPay(new Credentials
            {
                Id = 1010,
                Code = "demo",
                CRC = "3214",
                Password = "p@$$w0rd#@!"
            },
            new TPayApiAccess(new Routes("https://secure.tpay.com", "75f86137a6635df826e3efe2e66f7c9a946fdde1")));

            CreateResponse transaction = await tpay.CreateTransaction(new CreateData(100.99, "Transakcja testowa", 150, "Jan Kowalski", AcceptTos.TRUE)
            {
                ExpirationDate = DateTime.Now.AddDays(3)
            });

            BlikResponse blikResponse = await tpay.Blik(transaction, 123456);

        }
    }
}
