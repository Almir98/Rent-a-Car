﻿using RentaCar.Data.Requests.Booking;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
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
            var search = new BookingSearchRequest(){
                FirstName = txtBookingSearch.Text,
                StartDate=dtStartDate.Value.Date,
                EndDate = dtEndDate.Value.Date
            };

            if (chkDate.Checked){
                search.StartDate = null;
                search.EndDate = null;
            }
            else
            {
                if(search.EndDate.Value.Date <= search.StartDate.Value.Date)
                {
                    MessageBox.Show("The scope of period days must be at least 1 day and the end date must be greater than the start date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

            var result = await _serviceBooking.Get<List<Data.Model.Booking>>(search);

            List<frmAllBookingVM> finalList = new List<frmAllBookingVM>();
            foreach (var item in result)
            {
                frmAllBookingVM form = new frmAllBookingVM
                {
                    BookingId=item.BookingId,
                    StartDate=item.StartDate,
                    EndDate=item.EndDate,
                    FirstName=item.Customer.FirstName,
                    LastName=item.Customer.LastName,
                    ManufacturerName = item.Vehicle.VehicleModel.Manufacturer.ManufacturerName,
                    ModelName = item.Vehicle.VehicleModel.ModelName
                };
                finalList.Add(form);
            }
            dgvBooking.AutoGenerateColumns = false;
            dgvBooking.DataSource = finalList;
        }

        private async void frmAllBooking_Load(object sender, EventArgs e)
        {
            var list = await _serviceBooking.Get<List<Data.Model.Booking>>(null);

            List<frmAllBookingVM> newList = new List<frmAllBookingVM>();

            foreach (var item in list)
            {
                frmAllBookingVM form = new frmAllBookingVM
                {
                    BookingId = item.BookingId,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    FirstName = item.Customer.FirstName,
                    LastName = item.Customer.LastName,
                    ManufacturerName=item.Vehicle.VehicleModel.Manufacturer.ManufacturerName,
                    ModelName=item.Vehicle.VehicleModel.ModelName
                };
                newList.Add(form);
            }
            dgvBooking.AutoGenerateColumns = false;
            dgvBooking.DataSource = newList;
        }

        private void dgvBooking_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvBooking.SelectedRows[0].Cells[0].Value;
            frmBookingDetails frm = new frmBookingDetails(int.Parse(id.ToString()));
            frm.Show();
        }

    }
}
