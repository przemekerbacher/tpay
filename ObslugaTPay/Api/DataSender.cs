using Newtonsoft.Json;
using ObslugaTPay.Helpers.Contracts;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace ObslugaTPay.Api
{
    public abstract class DataSender
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private ISerializer _serializer;
        public DataSender()
        {
            _serializer = new Helpers.CustomJsonSerializer();
        }
        protected async Task<T> Post<T>(object data, string url)
        {
            T result = default(T);
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            var jsonData = _serializer.Serialize(data);

            request.AddParameter("application/json; charset=utf-8", jsonData, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            var response = await
            client.ExecuteAsync(request);

            try
            {
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<T>(response.Content);
                }

                Logger.Info("Posting to: {url}" +
                    "with data: {data}" +
                    "end with status: {status}"
                    ,url, jsonData, response.StatusCode);
                    
            }
            catch(Exception ex)
            {
                Logger.Error(ex.Message, "Error when trying post data.");
            }

            return result;
        }
    }
}
