using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingVehicle : ContentPage
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");

        BookingVehicleViewModel model = null;

        public BookingVehicle(Data.Model.Vehicle vehicle = null)
        {
            InitializeComponent();

            BindingContext = model = new BookingVehicleViewModel
            {
                Vehicle = vehicle
            };

            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, true);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            await model.RentCar();

        }

        // For renting car 

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Successfully! You rented car!", "OK");
        }
    }
}