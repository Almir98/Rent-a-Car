using RentaCar.Data.Requests.Booking;
using RentACar.Mobile.Views;
using System;
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

        DateTime _startDate=DateTime.Now;
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
                if(StartDate>=EndDate)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "The end date must be greater than the start date of the reservation", "Try again");
                    return;
                }

                var request = new BookingUpsert
                {
                    CustomerId = APIService.CustomerId,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    VehicleId = Vehicle.VehicleId,
                    RatingStatus = false,
                    CommentStatus = false
                };

                await _serviceBooking.Insert<Data.Model.Booking>(request);
                await Application.Current.MainPage.DisplayAlert("Message", "Successfully!", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Somethning went wrong", "Try again");
            }
        }

    }
}
