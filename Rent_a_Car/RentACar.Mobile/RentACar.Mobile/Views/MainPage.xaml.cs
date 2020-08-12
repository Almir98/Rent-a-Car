using RentACar.Mobile.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RentACar.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Customer:
                        MenuPages.Add(id, new NavigationPage(new CustomerInformationPage()));
                        break;
                    case (int)MenuItemType.Bookings:
                        MenuPages.Add(id, new NavigationPage(new MyBookingPage()));
                        break;
                    case (int)MenuItemType.Vehicle:
                        MenuPages.Add(id, new NavigationPage(new VehiclePage()));
                        break;
                    case (int)MenuItemType.Rating:
                        MenuPages.Add(id, new NavigationPage(new AllRatingsCustomer()));
                        break;
                    case (int)MenuItemType.Comment:
                        MenuPages.Add(id, new NavigationPage(new AllCommentsCustomer()));
                        break;
                    case (int)MenuItemType.Contact:
                        MenuPages.Add(id, new NavigationPage(new ContactPage()));
                        break;
                    case (int)MenuItemType.Logout:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}