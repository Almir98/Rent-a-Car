using RentaCar.Data.Requests.Booking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    class MyBookingViewModel : BaseViewModel
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");
        private readonly APIService _serviceBooking = new APIService("Booking");

        public ICommand Init { get; set; }
        public ICommand SearchVehicles { get; set; }

        public MyBookingViewModel()
        {
            Init = new Command(async () => await AllBookings());
            SearchVehicles = new Command(async () => await SearchBookingCar());
        }

        public ObservableCollection<Data.Model.Booking> BookingList { get; set; } = new ObservableCollection<Data.Model.Booking>();

        public Data.Model.Customer customer { get; set; }

        string _manufacturerName = string.Empty;
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { SetProperty(ref _manufacturerName, value); }
        }

        public async Task AllBookings() 
        {
                var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
                customer = customerID;

                var request = new BookingSearchRequest
                {
                    CustomerID = customer.CustomerId
                };

                BookingList.Clear();
                var list = await _serviceBooking.Get<List<Data.Model.Booking>>(request);

                foreach (var item in list)
                {
                    BookingList.Add(item);
                }

                if (BookingList.Count == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Warning", "You don't have any bookings yet.", "OK");
                }
        }

        public async Task SearchBookingCar()
        {
            var request = new BookingSearchRequest
            {
                ManufacturerName = ManufacturerName
            };

            var list = await _serviceBooking.Get<IEnumerable<Data.Model.Booking>>(request);
            BookingList.Clear();

            foreach (var item in list)
            {
                BookingList.Add(item);
            }
            if (BookingList.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Warning", "There are no results for this search", "Try again");
            }
        }


    }
}
