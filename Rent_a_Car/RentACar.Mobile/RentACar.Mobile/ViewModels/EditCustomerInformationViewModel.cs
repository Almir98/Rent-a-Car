using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RentaCar.Data.Requests.Customer;
using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    class EditCustomerInformationViewModel : BaseViewModel
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");

        public ICommand Init { get; set; }
        public ICommand SaveChanges { get; set; }

        public EditCustomerInformationViewModel()
        {
            Init = new Command(async () => await Initialization());
            SaveChanges = new Command(async () => await SaveEditChanges());
        }

        // properties for edit

        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private string _phone = string.Empty;
        public string PhoneNumber
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        private string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        private string _password = string.Empty;
        public string NewPassword
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _passwordconfirm = string.Empty;
        public string ConfirmPassword
        {
            get { return _passwordconfirm; }
            set { SetProperty(ref _passwordconfirm, value); }
        }

        private Data.Model.Customer customer { get; set; }
        
        
        public async Task Initialization()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
            PhoneNumber = customer.Phone;
            Username = customer.Username;
        }

        public async Task SaveEditChanges()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Email) ||
                    string.IsNullOrWhiteSpace(PhoneNumber) || string.IsNullOrWhiteSpace(Username))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "All fields are requreid", "Try again");
                    return;
                }

                if (Username.Length < 4)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Username must have minimum 4 characters", "Try again");
                    return;
                }

                var userList = await _serviceCustomer.Get<List<Data.Model.Customer>>(null);
                foreach (var item in userList)
                {
                    if (item.Username.StartsWith(Username) && APIService.Username != item.Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Username already exist", "Try again");
                        return;
                    }
                }

                var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
                customer = customerID;

                // Password

                var request = new CustomerUpsert
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Phone = PhoneNumber,
                    CityId = customer.CityId,
                    Email = Email,
                    Username = Username,
                    CustomerTypeId = 2,
                    Password=APIService.Password,
                    PasswordConfirm=APIService.Password
                };

                APIService.Username = Username;

                var userUpdate = await _serviceCustomer.Update<Data.Model.Customer>(APIService.CustomerId,request);
                await Application.Current.MainPage.DisplayAlert("Succesfull", "Succesfully changed, please log in with new credentials.", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Something went wrong.", "Try again");
            }
        }
    }
}
