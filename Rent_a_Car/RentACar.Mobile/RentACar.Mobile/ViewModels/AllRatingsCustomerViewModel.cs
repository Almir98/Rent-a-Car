﻿using RentaCar.Data.Requests.Booking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class AllRatingsCustomerViewModel : BaseViewModel
    {
        private readonly APIService _serviceCustomer = new APIService("Customer");
        private readonly APIService _serviceBooking = new APIService("Booking");


        public ICommand Init { get; set; }

        public AllRatingsCustomerViewModel()
        {
            Init = new Command(async () => await Initialization());
        }

        public ObservableCollection<Data.Model.Booking> BookingList { get; set; } = new ObservableCollection<Data.Model.Booking>();

        public Data.Model.Customer customer { get; set; }

        
        public async Task Initialization()
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
                if(item.RatingStatus==false && item.EndDate.Date<=DateTime.Now.Date)
                {
                    BookingList.Add(item);
                }
            }
            if (BookingList.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Warning", "The list is empty. You can leave a rating on the reserved vehicle after the reservation expires or you have not booked yet. Please, try again later.", "OK");
            }
        }
    }
}
