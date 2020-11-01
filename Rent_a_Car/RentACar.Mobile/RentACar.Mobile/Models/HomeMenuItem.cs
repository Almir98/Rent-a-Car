﻿namespace RentACar.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        Customer,
        Bookings,
        Vehicle,
        Rating,
        Comment,
        Contact,
        Logout,
        CustomerTest,


    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
