using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterNewAccount : ContentPage
    {
        public RegisterNewAccount()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Canceled(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}