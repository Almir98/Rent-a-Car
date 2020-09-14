using Data.Model;
using RentaCar.Data.Requests.VehicleModel;
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
    public partial class frmAddVehicleModel : Form
    {
        protected APIService _serviceManufacturer = new APIService("Manufacturer");
        protected APIService _serviceVehicleModel = new APIService("VehicleModel");

        public frmAddVehicleModel()
        {
            InitializeComponent();
        }

        private async Task LoadManufacturer()
        {
            var list = await _serviceManufacturer.Get<List<Manufacturer>>();
            list.Insert(0, new Manufacturer());

            cmbManufacturer.DisplayMember = "ManufacturerName";
            cmbManufacturer.ValueMember = "ManufacturerId";

            cmbManufacturer.DataSource = list;
        }
        private async void frmAddVehicleModel_Load(object sender, EventArgs e)
        {
            await LoadManufacturer();
        }

        private async void btnSaveManufacturer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var model = new VehicleModelUpsert()
                {
                    ModelName = txtModelName.Text
                };

                var idManufacturer = cmbManufacturer.SelectedValue;
                if (int.TryParse(idManufacturer.ToString(), out int manufacturerID))
                {
                    model.ManufacturerId = manufacturerID;
                }

                var request = new VehicleModelSearch{
                    ModelName = txtModelName.Text
                };
                var list = await _serviceVehicleModel.Get<List<Data.Model.VehicleModel>>(request);

                if(list.Count>=1)
                {
                    MessageBox.Show("This vehicle model has already been entered.Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    await _serviceVehicleModel.Insert<Data.Model.VehicleModel>(model);
                    MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txtModelName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelName.Text))
            {
                errorProvider1.SetError(txtModelName, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtModelName, null);
            }
        }
    }
}
