using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using RentaCar.Data;
using System.Windows.Forms;

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

        public async Task<T> Get<T>(object search=null)
        {
            try
            {
                var query = "";
                if (search != null)
                {
                    query = await search?.ToQueryString();
                }

                var list = await $"{Properties.Settings.Default.APIUrl}/{_route}?{query}"
                    .WithBasicAuth(Username, Password)
                    .GetJsonAsync<T>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Wrong username or password.", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Forbidden.", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        //Insert and update

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithBasicAuth(Username,Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id,object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username,Password).PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
