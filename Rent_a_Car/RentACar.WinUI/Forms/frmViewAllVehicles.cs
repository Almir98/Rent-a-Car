using RentaCar.Data.Requests.Vehicle;
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
                RegistrationNumber = txtSearchVehicle.Text
                //ManufacturerName=txtSearchVehicle.Text,
                //BranchName=txtSearchVehicle.Text
            };

            var result = await _service.Get<List<VehicleRequest>>(search);
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.DataSource = result;
        }

        private void dgvVehicles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvVehicles.SelectedRows[0].Cells[0].Value;
            frmVehicleDetails frm = new frmVehicleDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmViewAllVehicles_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<VehicleRequest>>(null);
            dgvVehicles.AutoGenerateColumns = false;
            dgvVehicles.DataSource = result;

        }
    }
}
