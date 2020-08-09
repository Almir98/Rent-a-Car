using RentaCar.Data.Requests.Vehicle;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RentACar.Mobile.ViewModels
{
    public class VehicleDetailsViewModel : BaseViewModel
    {
        private readonly APIService _serviceRating = new APIService("Rating");

        public ICommand InitCommand { get; set; }

        public VehicleDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        private string _rating = string.Empty;
        public string AverageRating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }


        public Data.Model.Vehicle vehicle { get; set; } = null;


        public async Task Init()
        {
            var allRatings = await _serviceRating.Get<List<Data.Model.Rating>>(null);

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
