using RentaCar.Data.Requests.Vehicle;
using System;
using System.Drawing;
using System.IO;
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

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        private async void frmVehicleDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var vehicle = await _apiservice.GetById<VehicleRequest>(_id);

                txtRegistration.Text = vehicle.RegistrationNumber;
                txtVehicleNumber.Text = vehicle.VehicleNumber.ToString();
                txtDailyPrice.Text = vehicle.DailyPrice.ToString();
                txtDescription.Text = vehicle.Description;
                txtMileage.Text = vehicle.Mileage;
                txtDate.Text = vehicle.ManufacturerDate.ToString();
                txtTransmission.Text = vehicle.Transmission;
                txtNumberOfSeats.Text = vehicle.NumberOfSeats.ToString();
                chkStatus.Checked = vehicle.Status.Value;

                txtManufacturer.Text = vehicle.VehicleModel.Manufacturer.ManufacturerName;
                txtModelName.Text = vehicle.VehicleModel.ModelName;

                pictureBox1.Image = GetImage(vehicle.Image);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
