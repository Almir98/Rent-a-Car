using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;

namespace RentACar.WinUI
{
    public class APIService
    {
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>()
        {
            var result =await $"{Properties.Settings.Default.APIUrl}/{_route}".GetJsonAsync<T>();
            return result;
        }





    }
}
