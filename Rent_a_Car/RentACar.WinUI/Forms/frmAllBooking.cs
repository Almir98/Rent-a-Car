using RentaCar.Data.Requests.Booking;
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

        private async void frmAllBooking_Load(object sender, EventArgs e)
        {
            var list = await _serviceBooking.Get<List<BookingRequest>>(null);

            List<frmAllBookingVM> newList = new List<frmAllBookingVM>();

            foreach (var item in list)
            {
                frmAllBookingVM form = new frmAllBookingVM
                {
                    BookingId=item.BookingId,
                    NumberOfDays=item.NumberOfDays,
                    TotalPrice=item.TotalPrice,
                    StartDate=item.StartDate,
                    EndDate=item.EndDate,
                    Canceled=item.Canceled,
                    Discount=item.Discount,
                    Description=item.Description,
                    FirstName=item.Customer.FirstName,
                    LastName=item.Customer.LastName,
                    RegistrationNumber=item.Vehicle.RegistrationNumber
                };
                newList.Add(form);
            }
            dgvBooking.DataSource = newList;


        }

    }
}
