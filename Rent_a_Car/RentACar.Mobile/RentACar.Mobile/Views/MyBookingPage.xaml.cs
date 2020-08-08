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
    public partial class MyBookingPage : ContentPage
    {
        private MyBookingViewModel model=null;

        public MyBookingPage()
        {
            InitializeComponent();
            BindingContext = model = new MyBookingViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.AllBookings();
        }
    }
}