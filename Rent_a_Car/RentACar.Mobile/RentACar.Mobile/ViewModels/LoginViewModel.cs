using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
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

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                List<Data.Model.Customer> list = await _service.Get<List<Data.Model.Customer>>(null);

                foreach (var item in list)
                {
                    if(item.Username==Username)
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
