using RentaCar.Data.Requests.Customer;
using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Customer");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public ICommand LoginCommand { get; set; }

        private static string GenerateSalt()
        {
            var buffer = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }

        private static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            if(string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "All fields are required", "Try again");
                return;
            }

            try
            {

                List<Data.Model.Customer> list = await _service.Get<List<Data.Model.Customer>>(new CustomerSearchRequest { 
                    
                    Username=Username
                });

                if(list.Count==0)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Wrong username or password", "Try again");
                    return;
                }

                foreach (var item in list)
                {
                    if (item.Username == Username)
                    {
                        APIService.CustomerId = item.CustomerId;
                    }
                }

                await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                 await Application.Current.MainPage.DisplayAlert("Error", "Wrong username or password", "Try again");
            }
        }
    }
}
