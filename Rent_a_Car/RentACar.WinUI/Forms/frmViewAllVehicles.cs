using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmViewAllVehicles : Form
    {
        private readonly APIService _service = new APIService("Vehicle");

        public frmViewAllVehicles()
        {
            InitializeComponent();
        }

        private async void btnShowVehicles_Click(object sender, EventArgs e)
        {
            var search = new VehicleSearchRequest()
            {
                ManufacturerName=txtSearchVehicle.Text
            };
            var result = await _service.Get<List<Data.Model.Vehicle>>(search);

            List<frmAllVehiclesVM> finalList = new List<frmAllVehiclesVM>();

            foreach (var item in result)
            {
                frmAllVehiclesVM form = new frmAllVehiclesVM
                {
                    VehicleId=item.VehicleId,
                    ManufacturerName=item.VehicleModel.Manufacturer.ManufacturerName,
                    ModelName=item.VehicleModel.ModelName,
                    RegistrationNumber=item.RegistrationNumber,
                    Image = item.Image,
                    Mileage = item.Mileage,
                    Transmission=item.Transmission,
                    NumberOfSeats=item.NumberOfSeats,
                    FuelName=item.FuelType.FuelName
                };
                finalList.Add(form);
            }
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.DataSource = finalList;
        }

        private void dgvVehicles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvVehicles.SelectedRows[0].Cells[0].Value;
            frmVehicleDetails frm = new frmVehicleDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmViewAllVehicles_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Data.Model.Vehicle>>(null);

            List<frmAllVehiclesVM> newList = new List<frmAllVehiclesVM>();

            foreach (var item in result)
            {
                frmAllVehiclesVM form = new frmAllVehiclesVM
                {
                    VehicleId=item.VehicleId,
                    ManufacturerName=item.VehicleModel.Manufacturer.ManufacturerName,
                    ModelName=item.VehicleModel.ModelName,
                    Image=item.Image,
                    RegistrationNumber=item.RegistrationNumber,
                    Mileage=item.Mileage,
                    Transmission=item.Transmission,
                    NumberOfSeats=item.NumberOfSeats,
                    FuelName=item.FuelType.FuelName
                };
                newList.Add(form);
            }
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.DataSource = newList;
        }
    }
}
