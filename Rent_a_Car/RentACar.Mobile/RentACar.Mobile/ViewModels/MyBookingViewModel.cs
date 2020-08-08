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

        public MyBookingViewModel()
        {
            Init = new Command(async () => await AllBookings());
        }

        public ObservableCollection<Data.Model.Booking> BookingList { get; set; } = new ObservableCollection<Data.Model.Booking>();

        public Data.Model.Customer customer { get; set; }

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
        }
    }
}
