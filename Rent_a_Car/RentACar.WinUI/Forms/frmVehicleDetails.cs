using RentaCar.Data.Requests;
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
    public partial class frmVehicleDetails : Form
    {
        private readonly APIService _apiservice = new APIService("Vehicle");
        private int? _id = null;

        public frmVehicleDetails(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmVehicleDetails_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var vehicle = await _apiservice.GetById<VehicleRequest>(_id);

                txtRegistracija.Text = vehicle.RegistrationNumber;
                txtVehicleNumber.Text = vehicle.VehicleNumber.ToString();
                txtDailyPrice.Text = vehicle.DailyPrice.ToString();
                txtDescription.Text = vehicle.Description;
                txtDate.Text = vehicle.ManufacturerDate.ToString();
                txtTransmission.Text = vehicle.Transmission;
                txtNumberOfSeats.Text = vehicle.NumberOfSeats.ToString();
                chkStatus.Checked = vehicle.Status.Value;
            }

        }

    }
}
