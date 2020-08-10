using RentaCar.Data.Requests.Recommend;
using RentaCar.Data.Requests.Vehicle;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class VehicleDetailsViewModel : BaseViewModel
    {
        private readonly APIService _serviceRating = new APIService("Rating");
        private readonly APIService _serviceRecommend = new APIService("Recommend");

        public ICommand InitCommand { get; set; }

        public VehicleDetailsViewModel()
        {
            InitCommand = new Command(async () => await Initialization());
        }

        private string _rating = string.Empty;
        public string AverageRating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }


        public Data.Model.Vehicle vehicle { get; set; } = null;

        public ObservableCollection<Data.Model.Vehicle> RecommendedVehicleList { get; set; } = new ObservableCollection<Data.Model.Vehicle>();

        public async Task Initialization()
        {
            var allRatings = await _serviceRating.Get<List<Data.Model.Rating>>(null);
            var request = new RecommendSearchRequest {
                VehicleId = vehicle.VehicleId
            };
            
            List<Data.Model.Vehicle> recList = await _serviceRecommend.Get<List<Data.Model.Vehicle>>(request);
            RecommendedVehicleList.Clear();

            foreach (var item in recList)
            {
                RecommendedVehicleList.Add(item);
            }

            float avgRating = 0;
            int i = 0;
            foreach (var item in allRatings)
            {
                if (vehicle.VehicleId == item.VehicleId)
                {
                    avgRating += item.RatingValue;
                    i++;
                }
            }
            if(avgRating==0)
            {
                AverageRating = "The car has no ratings yet";
                return;
            }
            AverageRating = (avgRating / i).ToString();
        }



    }
}
