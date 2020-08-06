namespace RentACar.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new RentACar.Mobile.App());
        }
    }
}
