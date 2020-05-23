using RentaCar.Data.Requests;
using RentaCar.Data.Requests.Vehicle;
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
                RegistrationNumber=txtSearchVehicle.Text
                //ManufacturerName=txtSearchVehicle.Text,
                //BranchName=txtSearchVehicle.Text
            };

            var result = await _service.Get<List<VehicleRequest>>(search);
            dgvVehicles.DataSource = result;
        }

        private void dgvVehicles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvVehicles.SelectedRows[0].Cells[0].Value;
            frmVehicleDetails frm = new frmVehicleDetails(int.Parse(1.ToString()));
            frm.Show();
        }
    }
}
