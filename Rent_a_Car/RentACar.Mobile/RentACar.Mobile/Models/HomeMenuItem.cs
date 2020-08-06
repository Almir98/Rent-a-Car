namespace RentACar.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        Customer,
        Vehicle,
        Rating,
        Comment,
        Contact,
        Logout

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
