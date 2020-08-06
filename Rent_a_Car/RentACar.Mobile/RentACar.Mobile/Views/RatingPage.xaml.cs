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
            await model.SetNewRating();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Successfully! Thank you for rating car!", "OK");
        }
    }
}