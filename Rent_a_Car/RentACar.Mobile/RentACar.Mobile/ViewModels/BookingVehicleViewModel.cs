using RentaCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class BookingVehicleViewModel
    {
        private readonly APIService _serviceBooking=new APIService("Booking");


        public BookingVehicleViewModel()
        {
            BookingInit = new Command(async () => await RentVehicle());
        }

        public ICommand BookingInit { get; set; }
        public Vehicle vehicle { get; set; }

        async Task RentVehicle()
        {

        }

    }
}
