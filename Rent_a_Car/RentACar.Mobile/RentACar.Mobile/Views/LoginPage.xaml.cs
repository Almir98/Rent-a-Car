using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            imgDisp.Source = "img.png";

        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterNewAccount());
        }
    }
}