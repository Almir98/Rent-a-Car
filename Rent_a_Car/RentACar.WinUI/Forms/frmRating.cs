using RentaCar.Data.Models;
using RentaCar.Data.Requests.Rating;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmRating : Form
    {
        protected readonly APIService _serviceRating =new APIService("Rating");

        public frmRating()
        {
            InitializeComponent();
        }

        private async void frmRating_Load(object sender, EventArgs e)
        {
            var list = await _serviceRating.Get<List<RatingRequest>>(null);
            
            List<frmRatingVM> newList = new List<frmRatingVM>();

            foreach (var item in list)
            {
                frmRatingVM form = new frmRatingVM
                {
                    RatingId=item.RatingId,
                    RatingValue=item.RatingValue,
                    FirstName=item.Customer.FirstName,
                    LastName=item.Customer.LastName,
                    Username=item.Customer.Username,
                    RegistrationNumber=item.Vehicle.RegistrationNumber,
                    ModelName=item.Vehicle.VehicleModel.ModelName,
                    ManufacturerName=item.Vehicle.VehicleModel.Manufacturer.ManufacturerName
                };
                newList.Add(form);
            }
            newList = newList.OrderBy(x => x.RatingValue).ToList();
            dgvRating.DataSource = newList;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new RatingSearchRequest()
            {
                ManufacturerName = txtVehicle.Text,
            };
            var list = await _serviceRating.Get<List<RatingRequest>>(search);
        }
    }
}
