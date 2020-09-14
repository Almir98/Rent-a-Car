﻿using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Vehicle;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class VehicleViewModel : BaseViewModel
    {
        private readonly APIService _vehicleService = new APIService("Vehicle");          
        private readonly APIService _bookingService = new APIService("Booking");


        public VehicleViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SearchVehicles = new Command(async () => await Load());

        }
        public ICommand InitCommand { get; set; }
        public ICommand SearchVehicles { get; set; }


        public ObservableCollection<Data.Model.Vehicle> VehicleList { get; set; } = new ObservableCollection<Data.Model.Vehicle>();

        string _manufacturerName = string.Empty;
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { SetProperty(ref _manufacturerName, value); }
        }

        string _branchName = string.Empty;
        public string BranchName
        {
            get { return _branchName; }
            set { SetProperty(ref _branchName, value); }
        }

        DateTime _startDate = DateTime.Now;
        public DateTime DateNow
        {
            get { return _startDate; }
            set { SetProperty(ref _startDate, value); }
        }

        public async Task Init()
        {
            var list = await _vehicleService.Get<IEnumerable<Data.Model.Vehicle>>(null);
            var bookingList = await _bookingService.Get<List<Data.Model.Booking>>(null);
            var key = true;

            VehicleList.Clear();
            foreach (var vehicle in list)
            {
                foreach (var item in bookingList)
                {
                    if(vehicle.VehicleId == item.VehicleId)
                    {
                        if(item.EndDate.Date > DateNow.Date)
                        {
                            key = false;
                        }
                    }
                }
                if (key == true)
                {
                    VehicleList.Add(vehicle);
                }
                key = true;
            }
            if (VehicleList.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Warning", "The list is empty. All vehicles we own are currently reserved.Please, try again later.", "OK");
            }
        }

        //Load search vehicles

        public async Task Load()
        {
            var request = new VehicleSearchRequest
            {
                ManufacturerName = ManufacturerName,
                BranchName=BranchName
            };

            var list = await _vehicleService.Get<IEnumerable<Data.Model.Vehicle>>(request);

            VehicleList.Clear();

            foreach (var item in list)
            {
                VehicleList.Add(item);
            }

            if (VehicleList.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Warning", "We do not offer this brand of vehicle", "Try again");
            }
        }
    }

}
