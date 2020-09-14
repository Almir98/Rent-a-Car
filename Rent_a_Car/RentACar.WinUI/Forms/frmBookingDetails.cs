﻿using RentaCar.Data.Requests.Booking;
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
                var booking = await _serviceBooking.GetById<Data.Model.Booking>(_id);

                txtReservationID.Text = booking.BookingId.ToString();
                dtStart.Value = booking.StartDate.AddHours(8).Date;
                dtEndDate.Value = booking.EndDate.Date;
                txtFirstName.Text = booking.Customer.FirstName;
                txtLastName.Text = booking.Customer.LastName;
                txtManufacturer.Text = booking.Vehicle.VehicleModel.Manufacturer.ManufacturerName;
                txtModel.Text = booking.Vehicle.VehicleModel.ModelName;
                txtDailyPrice.Text = booking.Vehicle.DailyPrice.ToString();

                var total = (booking.EndDate.Date - booking.StartDate.AddHours(8).Date).TotalDays;
                txtTotalDays.Text = total.ToString();

                total =total*booking.Vehicle.DailyPrice;
                txtTotalPrice.Text =total.ToString("#.##");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
