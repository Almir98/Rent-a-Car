using RentaCar.Data.Requests.Booking;
using System;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmBookingDetails : Form
    {
        protected readonly APIService _serviceBooking = new APIService("Booking");
        private int? _id = null;

        public frmBookingDetails(int? id)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmBookingDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var booking = await _serviceBooking.GetById<BookingRequest>(_id);

                txtReservationID.Text = booking.BookingId.ToString();
                txtNumberOfDays.Text = booking.NumberOfDays.ToString();
                txtTotalPrice.Text = booking.TotalPrice.ToString();
                dtStart.Value = booking.StartDate;
                dtEndDate.Value = booking.EndDate;
                chkCanceled.Checked = booking.Canceled.Value;
                txtDescription.Text = booking.Description;
                txtDisscount.Text = booking.Discount.ToString();
                txtFirstName.Text = booking.Customer.FirstName;
                txtLastName.Text = booking.Customer.LastName;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
