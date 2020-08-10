using RentaCar.Data.Requests.Customer;
using RentACar.Mobile.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditCustomerInformationPage : ContentPage
    {
        private EditCustomerInformationViewModel model = null;
        public EditCustomerInformationPage()
        {
            InitializeComponent();
            BindingContext = model = new EditCustomerInformationViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Initialization();
        }
    }
}