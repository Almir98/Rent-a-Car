using RentACar.Mobile.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RentACar.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommentPage : ContentPage
    {
        CommentViewModel model = new CommentViewModel();

        public CommentPage()
        {
            //InitializeComponent();
            BindingContext = model = new CommentViewModel();

            NavigationPage.SetHasBackButton(this, true);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.SetComment();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Successfully! Thank you for comment!", "OK");
        }
    }
}