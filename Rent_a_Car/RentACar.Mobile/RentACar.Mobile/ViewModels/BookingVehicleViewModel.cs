using RentaCar.Data.Requests.Booking;
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

        DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetProperty(ref _startDate, value); }
        }

        DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { SetProperty(ref _endDate, value); }
        }


        public Data.Model.Customer customer { get; set; }


        public async Task Init()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Phone = customer.Phone;
            Email = customer.Email;

                                            // dodat jos propertija od auta kad nadjem nacin  !!!
        }


        public Data.Model.Vehicle Vehicle { get; set; }

        public async Task RentCar()
        {
            try
            {
                var request = new BookingUpsert
                {
                    CustomerId = APIService.CustomerId,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    //VehicleId=Vehicle.VehicleId,
                    VehicleId = 1                                                    // ISPRAVIT 
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
