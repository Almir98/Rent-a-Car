using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using RentaCar.Data;

namespace RentACar.WinUI
{
    public class APIService
    {
        private string _route = null;

        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(Username,Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }


    }
}
