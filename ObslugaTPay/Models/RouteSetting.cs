using System.Collections;
using System.Collections.Generic;

namespace ObslugaTPay.Models
{
    public class RouteSetting
    {
        public RouteSetting(string origin, string apiKey)
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

        public string CreateUrl { get; set;  }
        public string BlikUrl { get; set; }
        public string GetUrl { get; set; }
        public string ChargebackUrl { get; set; }
        public string ChargebackAnyUrl { get; set; }
        public string StatusUrl { get; set; }

        private void SetRoutes()
        {
            CreateUrl = $"{origin}/api/gw/{apiKey}/transaction/create";
            BlikUrl = $"{origin}/api/gw/{apiKey}/transaction/blik";
            GetUrl = $"{origin}/api/gw/{apiKey}/transaction/get";
            ChargebackUrl = $"{origin}/api/gw/{apiKey}/chargeback/transaction";
            ChargebackAnyUrl = $"{origin}/api/gw/{apiKey}/chargeback/transaction/any";
            StatusUrl = $"{origin}/api/gw/{apiKey}/chargeback/chargeback/status";
        }
    }
}
    