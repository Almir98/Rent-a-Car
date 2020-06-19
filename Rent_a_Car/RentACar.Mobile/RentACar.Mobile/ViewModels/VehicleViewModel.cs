using RentaCar.Data.Requests;
using RentaCar.Data.Requests.Manufacturer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class VehicleViewModel
    {
        private readonly APIService _vehicleService=new APIService("Vehicle");          // connection to controller
        private readonly APIService _manufacturerService = new APIService("Manufacturer");

        public VehicleViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<ManufacturerRequest> ManufacturerList { get; set; } = new ObservableCollection<ManufacturerRequest>();
        
        public ObservableCollection<VehicleRequest> VehicleList { get; set; } = new ObservableCollection<VehicleRequest>();


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _vehicleService.Get<IEnumerable<VehicleRequest>>(null);
            
            var manufacturerList = await _manufacturerService.Get<IEnumerable<ManufacturerRequest>>(null);

            if (ManufacturerList.Count == 0)
            {
                foreach (var item in manufacturerList)
                {
                    ManufacturerList.Add(item);
                }
            }



            VehicleList.Clear();
            foreach (var vehicle in list)
            {
                VehicleList.Add(vehicle);
            }
        } 
    }
}
