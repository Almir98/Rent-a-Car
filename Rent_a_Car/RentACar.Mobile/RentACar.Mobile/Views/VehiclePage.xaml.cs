﻿using RentACar.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehiclePage : ContentPage
    {
        private VehicleViewModel model = null;

        public VehiclePage()
        {
            InitializeComponent();
            BindingContext = model = new VehicleViewModel();
            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetHasBackButton(this, true);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var clicked_item = e.Item as Data.Model.Vehicle;

            await Navigation.PushAsync(new VehicleDetailPage(clicked_item));
        }

    }
}