using RentaCar.Data.Requests.Vehicle;
using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleDetailPage : ContentPage
    {
        VehicleDetailsViewModel model = null;

        public VehicleDetailPage(Data.Model.Vehicle item)
        {
            InitializeComponent();

            BindingContext = model = new VehicleDetailsViewModel
            {
                vehicle = item
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Booking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookingVehicle());
        }
    }
}