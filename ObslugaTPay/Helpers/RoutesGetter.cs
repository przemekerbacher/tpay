using ObslugaTPay.Models;
using System.Reflection;
using System.Collections.Generic;

namespace ObslugaTPay.Helpers
{
    public class RoutesGetter
    {
        private RouteSetting _routes;

        public RoutesGetter(RouteSetting routes)
        {
            _routes = routes;
        }
        public IDictionary<string, string> GetRoutesDictionary()
        {
            var routes = new Dictionary<string, string>();
            foreach (PropertyInfo property in _routes.GetType().GetProperties())
            {
                if (property.Name.Contains("Url"))
                {
                    routes.Add(property.Name, property.GetValue(_routes).ToString());
                }
            }

            return routes;
        }
    }
}
