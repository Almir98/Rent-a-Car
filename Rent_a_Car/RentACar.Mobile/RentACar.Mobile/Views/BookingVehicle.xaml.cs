using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingVehicle : ContentPage
    {
        BookingVehicleViewModel model = null;

        public BookingVehicle(Data.Model.Vehicle vehicle)
        {
            InitializeComponent();

            BindingContext = model = new BookingVehicleViewModel
            {
                Vehicle = vehicle
            };

            NavigationPage.SetHasBackButton(this, true);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}