using RentaCar.Data.Requests.Booking;
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
    public partial class frmAllBooking : Form
    {
        protected APIService _serviceCustomer = new APIService("Customer");
        protected APIService _serviceBooking = new APIService("Booking");

        public frmAllBooking()
        {
            InitializeComponent();
        }

        private async void btnBooking_Click(object sender, EventArgs e)
        {
            var search = new BookingSearchRequest()
            {
                CustomerFirstName = txtBookingSearch.Text
            };

            var result = await _serviceBooking.Get<List<BookingRequest>>(search);
            dgvBooking.DataSource = result;
        }
    }
}
