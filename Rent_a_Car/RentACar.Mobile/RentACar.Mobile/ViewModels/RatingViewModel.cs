using RentaCar.Data.Requests.Rating;
using System;
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

        //Rating value

        public int _ratingValue = 0;
        public int Mark
        {
            get { return _ratingValue; }
            set { SetProperty(ref _ratingValue, value); }
        }

        // data

        public Data.Model.Vehicle vehicle { get; set; }

        public Data.Model.Customer customer { get; set; }


        public async Task Initialization()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;

            var vehicleID = await _serviceVehicle.GetById<Data.Model.Vehicle>(vehicle.VehicleId);
            vehicle = vehicleID;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Manufacturer = vehicle.VehicleModel.Manufacturer.ManufacturerName;
        }


        public async Task SetNewRating()
        {
            try
            {
                var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
                customer = customerID;

                var vehicleID = await _serviceVehicle.GetById<Data.Model.Vehicle>(vehicle.VehicleId);


                bool answer = await Application.Current.MainPage.DisplayAlert("Alert", "Would you like to add rating?", "Yes", "No");
                if (answer)
                {
                    var request = new RatingUpsert
                    {
                        CustomerId = APIService.CustomerId,
                        VehicleId =vehicle.VehicleId,                                    
                        RatingValue = Mark
                    };

                    if (Mark <= 0 || Mark > 10)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "You have to add mark in range 1 - 10!", "OK");
                        return;
                    }

                    await _serviceRating.Insert<Data.Model.Rating>(request);
                    await Application.Current.MainPage.DisplayAlert("Message", "Successfully! You added your mark for rented car!", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Somethning went wrong", "Try again");
            }
        }
    }
}
