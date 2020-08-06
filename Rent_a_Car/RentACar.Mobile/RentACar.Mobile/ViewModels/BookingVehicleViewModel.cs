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

        public BookingVehicleViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RentCommand = new Command(async () => await RentCar());
        }

        public ICommand InitCommand { get; set; }
        public ICommand RentCommand { get; set; }


        //FirstName
        string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        //LAST NAME
        string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        // Phone
        string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        // EMAIL
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _registration = string.Empty;
        public string RegistationNumber
        {
            get { return _registration; }
            set { SetProperty(ref _registration, value); }
        }


        public Data.Model.Customer customer { get; set; }


        // Initialization
        public async Task Init()
        {
            var customerID = await _serviceCustomer.GetById<Data.Model.Customer>(APIService.CustomerId);
            customer = customerID;
            RegistationNumber = Vehicle.RegistrationNumber;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Phone = customer.Phone;
            Email = customer.Email;
        }

        // renting
        public Data.Model.Vehicle Vehicle { get; set; }

        public async Task RentCar()
        {
            var request = new BookingUpsert
            {
                CustomerId = APIService.CustomerId,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                //VehicleId=Vehicle.VehicleId,
                VehicleId = 1
            };

            await _serviceBooking.Insert<Data.Model.Booking>(request);
        }

    }
}
