﻿using RentaCar.Data.Requests.Customer;
using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class RegisterNewAccountViewModel
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");

        public ICommand RegisterCommand { get; set; }

        public RegisterNewAccountViewModel()
        {
            RegisterCommand = new Command(async () => await Register());

        }

        // propertiji
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public int CityId = 1;


        async Task Register()
        {
            try
            {
                if (Password != PasswordConfirm)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Password don't match", "Try again");
                    return;
                }

                if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email)
                    || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordConfirm))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "All fields are required", "Try again");
                    return;
                }

                var userList = await _serviceCustomer.Get<List<Data.Model.Customer>>(null);
                foreach (var item in userList)
                {
                    if (item.Username == Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Username already exist !", "Try again");
                        return;
                    }
                }

                var request = new CustomerUpsert
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Phone = Phone,
                    Email = Email,
                    CityId = CityId,
                    Username = Username,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm,
                    CustomerTypeId = 2
                };

                await _serviceCustomer.Insert<Data.Model.Customer>(request);

                await Application.Current.MainPage.DisplayAlert("Registred succesfully.", "Now just log in.", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            catch (Exception err)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Wrong input", "Try again");
            }
        }

    }
}
