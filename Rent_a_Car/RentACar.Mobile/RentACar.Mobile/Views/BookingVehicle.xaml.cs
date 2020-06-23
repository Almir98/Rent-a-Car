using RentaCar.Data.Requests.Vehicle;
using RentACar.Mobile.ViewModels;
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
    public partial class BookingVehicle : ContentPage
    {
        BookingVehicleViewModel model = null;

        public BookingVehicle(VehicleRequest car=null)
        {
            InitializeComponent();

            BindingContext = model = new BookingVehicleViewModel
            {
                vehicle = car
            };
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            //await model.InitCommand();
        }





    }
}