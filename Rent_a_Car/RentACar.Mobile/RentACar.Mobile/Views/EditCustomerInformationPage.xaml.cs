using RentaCar.Data.Requests.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditCustomerInformationPage : ContentPage
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");
        public EditCustomerInformationPage()
        {
            InitializeComponent();
            FirstName.Text = APIService.Customer.FirstName;
            LastName.Text = APIService.Customer.LastName;
            Email.Text = APIService.Customer.Email;
            Phone.Text = APIService.Customer.Phone;
            Username.Text = APIService.Customer.Username;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(FirstName.Text) || string.IsNullOrWhiteSpace(LastName.Text) || string.IsNullOrWhiteSpace(Email.Text) ||
                    string.IsNullOrWhiteSpace(Phone.Text) || string.IsNullOrWhiteSpace(Username.Text))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "All fields are requreid", "Try again");
                    return;
                }

                if(Username.Text.Length<4)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Username must have minimum 4 characters", "Try again");
                    return;
                }

                var userList = await _serviceCustomer.Get<List<Data.Model.Customer>>(null);
                foreach (var item in userList)
                {
                    if(item.Username.StartsWith(Username.Text) && APIService.Username!=item.Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Username already exist", "Try again");
                        return;
                    }
                }

                var userUpdate = await _serviceCustomer.Update<Data.Model.Customer>(APIService.CustomerId,new CustomerUpsert
                {
                    FirstName=FirstName.Text,
                    LastName=LastName.Text,
                    Phone=Phone.Text,
                    Email=Email.Text,
                    Username=Username.Text,
                    UserTypeId=2
                });

                if (userUpdate == default(Data.Model. Customer))
                    return;

                // Password

                if (OldPassword.Text != APIService.Password)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Wrondg old password", "Try again");
                }

                if (NewPassword.Text != ConfirmPassword.Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Password are not matched", "Try again");
                }

                if (NewPassword.Text.Length < 4)
                {
                    await Application.Current.MainPage.DisplayAlert("Eror", "Password must have minimum 4 characters", "Try again");
                }

                await _serviceCustomer.Update<Data.Model.Customer>(APIService.CustomerId, new CustomerUpsert
                {
                    Password = NewPassword.Text,
                    PasswordConfirm = ConfirmPassword.Text
                });

                APIService.Password = Username.Text;
                APIService.Password = NewPassword.Text;
                await Application.Current.MainPage.DisplayAlert("Succesfull", "Succesfully changed, please log in to confirm changes.", "OK");
                await Navigation.PushAsync(new LoginPage());

            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Something went wrong.", "Try again");
            }
        }
    }
}