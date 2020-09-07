using RentaCar.Data.Requests.Booking;
using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class BookingVehicleViewModel : BaseViewModel
    {
        private readonly APIService _serviceBooking = new APIService("Booking");
        private readonly APIService _serviceCustomer = new APIService("Customer");
        private readonly APIService _serviceVehicle = new APIService("Vehicle");


        public BookingVehicleViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RentCommand = new Command(async () => await RentCar());
        }

        public ICommand InitCommand { get; set; }
        public ICommand RentCommand { get; set; }

        string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }


        DateTime _startDate= DateTime.Now;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetProperty(ref _startDate, value); }
        }

        DateTime _endDate=DateTime.Now;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { SetProperty(ref _endDate, value); }
        }


        string _manufacturerName = string.Empty;
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { SetProperty(ref _manufacturerName, value); }
        }

        string _modelName = string.Empty;
        public string ModelName
        {
            get { return _modelName; }
            set { SetProperty(ref _modelName, value); }
        }

        public float _totalPrice = 0;
        public float TotalPrice
        {
            get { return _totalPrice; }
            set { SetProperty(ref _totalPrice, value); }
        }

        public Data.Model.Customer customer { get; set; }

        public async Task Init()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);

            FirstName = customerID.FirstName;
            LastName = customerID.LastName;
            Phone = customerID.Phone;
            Email = customerID.Email;
            ManufacturerName = Vehicle.VehicleModel.Manufacturer.ManufacturerName;
            ModelName = Vehicle.VehicleModel.ModelName;
        }

        public Data.Model.Vehicle Vehicle { get; set; }

        public async Task RentCar()
        {
            try
            {

                if(StartDate.Date < DateTime.Now.Date)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You cannot book before today", "Try again");
                    return;
                }

                if (StartDate.Date == EndDate.Date || EndDate.Date <= StartDate.Date)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "The scope of booking period must be at least 1 day and the end date must be greater than the start date.", "Try again");
                    return;
                }

                var search = new BookingSearchRequest
                {
                    VehicleID = Vehicle.VehicleId
                };
                var listBooking = await _serviceBooking.Get<List<Data.Model.Booking>>(search);

                foreach (var item in listBooking)
                {
                    if(item.EndDate.Date >= DateTime.Now.Date)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "The vehicle is already reserved. After the reservation expires, you can reserve the vehicle again", "Try again");
                        return;
                    }
                }

                var request = new BookingUpsert
                {
                    CustomerId = APIService.CustomerId,
                    StartDate = StartDate.Date,
                    EndDate = EndDate.Date,
                    VehicleId = Vehicle.VehicleId,
                    RatingStatus = false,
                    CommentStatus = false
                };
                await _serviceBooking.Insert<Data.Model.Booking>(request);

                var days = (request.EndDate.Date - request.StartDate.Date).TotalDays;
                var total = Vehicle.DailyPrice * days;

                var message = string.Format("Successfully! Total price for {0} days of reservation cost {1} KM.", days,total);
                await Application.Current.MainPage.DisplayAlert("Message", message, "OK");
            
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Somethning went wrong", "Try again");
            }
        }
    }
}
