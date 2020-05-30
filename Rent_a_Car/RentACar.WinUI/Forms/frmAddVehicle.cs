using Rent_a_Car.WebAPI.Database;
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
    public partial class frmAddVehicle : Form
    {
        protected APIService _serviceVehicle = new APIService("Vehicle");
        protected APIService _serviceFuelType = new APIService("FuelType");

        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private async Task LoadFuelType()
        {
            var list = await _serviceFuelType.Get<List<FuelType>>();
            list.Insert(0, new FuelType());
            cmbFuelType.ValueMember = "Id";
            cmbFuelType.DisplayMember = "Type";

            cmbFuelType.DataSource = list;
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
