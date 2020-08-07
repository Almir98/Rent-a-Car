using RentaCar.Data.Requests.Rating;
using System;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmRatingDetails : Form
    {
        protected readonly APIService _serviceRating = new APIService("Rating");
        private int? _id = null;

        public frmRatingDetails(int? id)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmRatingDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var rating = await _serviceRating.GetById<Data.Model.Rating>(_id);

                txtFirstName.Text = rating.Customer.FirstName;
                txtLastName.Text = rating.Customer.LastName;
                txtUsername.Text = rating.Customer.Username;
                txtCity.Text = rating.Customer.City.CityName;
                txtManufacturer.Text = rating.Vehicle.VehicleModel.Manufacturer.ManufacturerName;
                txtModelName.Text = rating.Vehicle.VehicleModel.ModelName;
                txtRegistrationNumber.Text = rating.Vehicle.RegistrationNumber;
                txtRatingValue.Text = rating.RatingValue.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
