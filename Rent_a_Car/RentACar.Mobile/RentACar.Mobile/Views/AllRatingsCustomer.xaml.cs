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
    public partial class AllRatingsCustomer : ContentPage
    {
        private AllRatingsCustomerViewModel model=null;
        public AllRatingsCustomer()
        {
            InitializeComponent();
            BindingContext = model = new AllRatingsCustomerViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Initialization();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var clicked_item = e.Item as Data.Model.Booking;

            await Navigation.PushAsync(new RatingPage(clicked_item.Vehicle));
        }




    }
}