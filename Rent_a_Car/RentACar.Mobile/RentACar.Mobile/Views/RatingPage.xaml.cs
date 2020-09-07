using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingPage : ContentPage
    {
        RatingViewModel model = null;

        public RatingPage(Data.Model.Vehicle clicked_vehicle)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, true);

            BindingContext = model = new RatingViewModel
            {
                vehicle=clicked_vehicle
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Initialization();
        }
    }
}