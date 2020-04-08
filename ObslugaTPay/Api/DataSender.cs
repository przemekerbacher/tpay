using Newtonsoft.Json;
using ObslugaTPay.Helpers.Contracts;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace ObslugaTPay.Api
{
    public abstract class DataSender
    {
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
                else
                {
                    Console.WriteLine(response.StatusCode);
                }
            }
            catch
            {
                //Log
                Console.WriteLine(response.Content);
            }


            return result;
        }
    }
}
