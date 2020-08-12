using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Vehicle;
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
        private readonly APIService _manufacturerService = new APIService("Manufacturer");

        public VehicleViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SearchVehicles = new Command(async () => await Load());

        }
        public ICommand InitCommand { get; set; }
        public ICommand SearchVehicles { get; set; }


        public ObservableCollection<Data.Model.Manufacturer> ManufacturerList { get; set; } = new ObservableCollection<Data.Model.Manufacturer>();

        public ObservableCollection<Data.Model.Vehicle> VehicleList { get; set; } = new ObservableCollection<Data.Model.Vehicle>();

        string _manufacturerName = string.Empty;
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { SetProperty(ref _manufacturerName, value); }
        }


        public async Task Init()
        {
            var list = await _vehicleService.Get<IEnumerable<Data.Model.Vehicle>>(null);

            VehicleList.Clear();
            foreach (var vehicle in list)
            {
                VehicleList.Add(vehicle);
            }
        }

        //Load search vehicles

        public async Task Load()
        {
            var request = new VehicleSearchRequest
            {
                ManufacturerName = ManufacturerName
            };

            var list = await _vehicleService.Get<IEnumerable<Data.Model.Vehicle>>(request);

            VehicleList.Clear();

            foreach (var item in list)
            {
                VehicleList.Add(item);
            }
        }
    }

}
