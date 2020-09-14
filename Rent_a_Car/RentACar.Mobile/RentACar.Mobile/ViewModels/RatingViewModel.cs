using RentaCar.Data.Requests.Booking;
using RentaCar.Data.Requests.Rating;
using RentACar.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class RatingViewModel : BaseViewModel
    {
        private readonly APIService _serviceRating = new APIService("Rating");
        private readonly APIService _serviceCustomer = new APIService("Customer");
        private readonly APIService _serviceVehicle = new APIService("Vehicle");
        private readonly APIService _serviceBooking = new APIService("Booking");

        public ICommand RatingCommand { get; set; }
        public ICommand Init { get; set; }

        public RatingViewModel()
        {
            Init = new Command(async () => await Initialization());
            RatingCommand = new Command(async () => await SetNewRating());
        }

        // propertiji

        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        public string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public string _manufacturer = string.Empty;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { SetProperty(ref _manufacturer, value); }
        }

        public string _modelName = string.Empty;
        public string ModelName
        {
            get { return _modelName; }
            set { SetProperty(ref _modelName, value); }
        }


        //Rating value

        public int _ratingValue = 0;
        public int Mark
        {
            get { return _ratingValue; }
            set { SetProperty(ref _ratingValue, value); }
        }

        DateTime _date = DateTime.Now;
        public DateTime RatingDate
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        // data

        public Data.Model.Vehicle vehicle { get; set; }

        public Data.Model.Customer customer { get; set; }


        public async Task Initialization()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;
            FirstName = customerID.FirstName;
            LastName = customer.LastName;

            var vehicleID = await _serviceVehicle.GetById<Data.Model.Vehicle>(vehicle.VehicleId);
            vehicle = vehicleID;

            Manufacturer = vehicle.VehicleModel.Manufacturer.ManufacturerName;
            ModelName = vehicle.VehicleModel.ModelName;
        }


        public async Task SetNewRating()
        {
            if (Mark <= 0 || Mark > 10)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You have to add mark in range 1 - 10!", "OK");
                return;
            }

            try
            {
                var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
                customer = customerID;

                var car = await _serviceVehicle.GetById<Data.Model.Vehicle>(vehicle.VehicleId);

                bool answer = await Application.Current.MainPage.DisplayAlert("Alert", "Would you like to add rating?", "Yes", "No");
                if (answer)
                {
                    var request = new RatingUpsert
                    {
                        CustomerId = APIService.CustomerId,
                        VehicleId =vehicle.VehicleId,                                    
                        RatingValue = Mark,
                        RatingDate=DateTime.Now.Date
                    };

                    var listRatings = await _serviceRating.Get<List<Data.Model.Rating>>(new RatingSearchRequest
                    {
                        CustomerID = customer.CustomerId,
                        VehicleId = vehicle.VehicleId
                    });

                    foreach (var rat in listRatings)
                    {
                        rat.RatingDate = rat.RatingDate.AddHours(8);
                        if (RatingDate.Date==rat.RatingDate.Date)
                        {
                            await Application.Current.MainPage.DisplayAlert("Message", "Rating for this reservation already exist! You can add just 1 rating for reservation", "Try again");
                            return;
                        }
                    }
                    request.RatingDate = DateTime.Now.Date;
                    await _serviceRating.Insert<Data.Model.Rating>(request);
                    await Application.Current.MainPage.DisplayAlert("Message", "Successfully! You added your mark for rented car!", "OK");


                    var listBooking = await _serviceBooking.Get<List<Data.Model.Booking>>(new BookingSearchRequest
                    {
                        CustomerID = customer.CustomerId
                    });

                    foreach (var item in listBooking)
                    {
                        if(item.VehicleId == car.VehicleId && item.CustomerId==customer.CustomerId)
                        {
                            if(item.RatingStatus==false)
                            {
                                var req = new BookingUpsert
                                {
                                    CustomerId = item.CustomerId,
                                    VehicleId = item.VehicleId,
                                    StartDate = item.StartDate,
                                    EndDate = item.EndDate,
                                    RatingStatus = true,
                                    CommentStatus = item.CommentStatus
                                };
                                await _serviceBooking.Update<Data.Model.Booking>(item.BookingId, req);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Somethning went wrong", "Try again");
            }
        }
    }
}
