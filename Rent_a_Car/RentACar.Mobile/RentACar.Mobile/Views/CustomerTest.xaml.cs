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
    public partial class CustomerTest : ContentPage
    {
        public CustomerTestVM model = null;
        public CustomerTest()
        {
            InitializeComponent();
            BindingContext = model = new CustomerTestVM();
        }

        protected async  override void OnAppearing()
        {
            base.OnAppearing();
            await model.Punjenje();
            await model.Filtiranje();

        }
    }


}