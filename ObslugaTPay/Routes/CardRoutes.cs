namespace ObslugaTPay.Routes
{
    public class CardRoutes: RouteSettings
    {
        public CardRoutes(string origin, string apiKey): base(origin, apiKey)
        {
            Origin = origin;
            ApiKey = apiKey;

            SetRoutes();
        }

        public string SecureSaleUrl { get; set; }
        public string RegisterSaleUrl { get; set; }
        public string PresaleUrl { get; set; }
        public string SaleUrl { get; set; }
        public string DeregisterUrl { get; set; }
        public string VisacheckoutPrepareUrl { get; set; }
        public string VisacheckoutFinishUrl { get; set; }
        public string RefundUrl { get; set; }
        public string CheckUrl { get; set; }

        public override void SetRoutes()
        {
            SecureSaleUrl = $"{Origin}/api/gw/{ApiKey}/securesale";
            RegisterSaleUrl = $"{Origin}/api/gw/{ApiKey}/register_sale";
            PresaleUrl = $"{Origin}/api/gw/{ApiKey}/presale";
            SaleUrl = $"{Origin}/api/gw/{ApiKey}/sale";
            DeregisterUrl = $"{Origin}/api/gw/{ApiKey}/deregister";
            VisacheckoutPrepareUrl = $"{Origin}/api/gw/{ApiKey}/visacheckout_prepare";
            VisacheckoutFinishUrl = $"{Origin}/api/gw/{ApiKey}/visacheckout_finish";
            RefundUrl = $"{Origin}/api/gw/{ApiKey}/refund";
            CheckUrl = $"{Origin}/api/gw/{ApiKey}/check";
        }
    }
}
    