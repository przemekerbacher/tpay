using Newtonsoft.Json;
using ObslugaTPay.Helpers.Contracts;

namespace ObslugaTPay.Helpers
{
    public class CustomJsonSerializer: ISerializer
    {
        public JsonSerializerSettings Settings { get; set; } = new JsonSerializerSettings();

        public CustomJsonSerializer()
        {
            Settings.NullValueHandling = NullValueHandling.Ignore;
        }


        public CustomJsonSerializer(JsonSerializerSettings settings)
        {
            Settings = settings;
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Settings);
        }

    }
}
