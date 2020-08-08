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
    public partial class CommentPage : ContentPage
    {
        public CommentViewModel model = null;
        public CommentPage()
        {
            InitializeComponent();
            BindingContext = model = new CommentViewModel
            {
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.InitializationField();
        }
    }
}