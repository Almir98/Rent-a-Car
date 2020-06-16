using RentaCar.Data.Requests.Rating;
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
                var rating = await _serviceRating.GetById<RatingRequest>(_id);

                txtFirstName.Text = rating.Customer.FirstName;
                txtLastName.Text = rating.Customer.LastName;
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
