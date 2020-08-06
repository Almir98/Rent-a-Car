using RentACar.Mobile.Models;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace RentACar.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Customer, Title="Customer profile" },
                new HomeMenuItem {Id = MenuItemType.Vehicle, Title="Vehicle" },
                new HomeMenuItem {Id = MenuItemType.Contact, Title="Contact us" },
                new HomeMenuItem {Id = MenuItemType.Rating, Title="Rate car" },
                new HomeMenuItem {Id = MenuItemType.Comment, Title="Leave a comment" },
                new HomeMenuItem {Id = MenuItemType.Logout, Title="Logout" },

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}