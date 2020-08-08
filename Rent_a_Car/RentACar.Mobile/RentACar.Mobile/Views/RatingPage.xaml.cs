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

        public RatingPage()
        {
            InitializeComponent();

            BindingContext = model = new RatingViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Initialization();
        }
    }
}