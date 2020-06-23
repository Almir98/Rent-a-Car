using RentaCar.Data.Models;
using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Vehicle;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class BookingVehicleViewModel: BaseViewModel
    {
        private readonly APIService _serviceBooking=new APIService("Booking");
        private readonly APIService _serviceVehicle = new APIService("Vehicle");
        private readonly APIService _serviceCustomer = new APIService("Customer");



        public BookingVehicleViewModel()
        {
            BookingInit = new Command(async () => await InitCommand());
        }

        public ICommand BookingInit { get; set; }



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

        // Manufacturer
        string _manufacturer = string.Empty;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { SetProperty(ref _email, value); }
        }


        public CustomerRequest customer { get; set; }
        public VehicleRequest vehicle { get; set; }
        
        public async Task InitCommand()
        {
            var vehicleID = await _serviceVehicle.GetById<VehicleRequest>(vehicle.VehicleId);

            var customerID = await _serviceCustomer.GetById<CustomerRequest>(APIService.CustomerId);

            vehicle = vehicleID;
            customer = customerID;

            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Phone = customer.Phone;
            Email = customer.Email;
            Manufacturer = vehicle.VehicleModel.Manufacturer.ManufacturerName;
        }

    }
}
