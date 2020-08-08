using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerInformationPage : ContentPage
    {
        CustomerInformationViewModel model = null;

        public CustomerInformationPage()
        {
            InitializeComponent();

            BindingContext = model = new CustomerInformationViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        //private async void Logout_Clicked(object sender,EventArgs e)
        //{
        //    var login_page = new LoginPage();
        //    Navigation.InsertPageBefore(login_page, this);
        //    await Navigation.PopAsync();
        //}


        private async void Button_Clicked_Edit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditCustomerInformationPage());
        }

    }
}