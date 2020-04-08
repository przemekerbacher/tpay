namespace ObslugaTPay.Models
{
    public class Routes
    {
        public Routes(string origin, string apiKey)
        {
            Origin = origin;
            ApiKey = apiKey;

            SetRoutes();
        }
        private string apiKey;

        public string ApiKey
        {
            get { return apiKey; }
            set { SetRoutes();  apiKey = value; }
        }

        private string origin;

        public string Origin
        {
            get { return origin; }
            set { SetRoutes();  origin = value; }
        }

        public string Create { get; set;  }
        public string Blik { get; set; }
        public string Get { get; set; }
        public string Chargeback { get; set; }
        public string ChargebackAny { get; set; }
        private void SetRoutes()
        {
            Create = $"{origin}/api/gw/{apiKey}/transaction/create";
            Blik = $"{origin}/api/gw/{apiKey}/transaction/blik";
            Get = $"{origin}/api/gw/{apiKey}/transaction/get";
            Chargeback = $"{origin}/api/gw/{apiKey}/chargeback/transaction";
            ChargebackAny = $"{origin}/api/gw/{apiKey}/chargeback/transaction/any";
        }
    }
}
    