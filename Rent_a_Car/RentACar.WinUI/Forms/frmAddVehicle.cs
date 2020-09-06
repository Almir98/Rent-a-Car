using Data.Model;
using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.Requests.VehicleModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmAddVehicle : Form
    {
        protected APIService _serviceVehicle = new APIService("Vehicle");
        protected APIService _serviceFuelType = new APIService("FuelType");
        protected APIService _serviceBranch = new APIService("Branch");
        protected APIService _serviceVehicleType = new APIService("VehicleType");
        protected APIService _serviceManufacturer = new APIService("Manufacturer");
        protected APIService _serviceVehicleModel = new APIService("VehicleModel");

        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private async Task LoadFuelType()
        {
            var list = await _serviceFuelType.Get<List<FuelType>>();
            list.Insert(0, new FuelType());

            cmbFuelType.DisplayMember = "FuelName";
            cmbFuelType.ValueMember = "FuelTypeId";

            cmbFuelType.DataSource = list;
        }

        private async Task LoadBranch()
        {
            var list = await _serviceBranch.Get<List<Branch>>();
            list.Insert(0, new Branch());

            cmbBranch.DisplayMember = "BranchName";
            cmbBranch.ValueMember = "BranchId";

            cmbBranch.DataSource = list;
        }


        private async Task LoadVehicleType()
        {
            var list = await _serviceVehicleType.Get<List<VehicleType>>();
            list.Insert(0, new VehicleType());

            cmbVehicleType.DisplayMember = "TypeName";
            cmbVehicleType.ValueMember = "VehcileTypeId";

            cmbVehicleType.DataSource = list;
        }

        private async Task LoadManufacturer()
        {
            var list = await _serviceManufacturer.Get<List<Manufacturer>>();
            list.Insert(0, new Manufacturer());

            cmbManufacturer.DisplayMember = "ManufacturerName";
            cmbManufacturer.ValueMember = "ManufacturerId";

            cmbManufacturer.DataSource = list;
        }

        private async Task LoadVehicleModel(int? id)
        {
            var list = await _serviceVehicleModel.Get<List<VehicleModel>>(new VehicleModelRequest
            {
                ManufacturerId = id
            });

            list.Insert(0, new VehicleModel());

            cmbVehicleModel.DisplayMember = "ModelName";
            cmbVehicleModel.ValueMember = "ModelId";

            cmbVehicleModel.DataSource = list;
        }


        private async void frmAddVehicle_Load(object sender, EventArgs e)       // load forme
        {
            await LoadFuelType();
            await LoadVehicleType();
            await LoadBranch();
            await LoadManufacturer();
        }

        private async void cmbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbManufacturer.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVehicleModel(id);
            }
        }

        VehicleUpsert request = new VehicleUpsert();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.RegistrationNumber = txtRegistrationNumber.Text;
                request.VehicleNumber = int.Parse(txtVehicleNumber.Text);
                request.DailyPrice = double.Parse(txtDailyPrice.Text);
                request.Description = rtxDescription.Text;
                request.ManufacturerDate = dtDte.Value;
                request.Mileage = txtMileage.Text;
                request.Transmission = txtTransmission.Text;
                request.NumberOfSeats = int.Parse(txtNumberOfSeats.Text);
                request.Status = chkStatus.Checked;

                // ove foreign moraju se posebno parsat

                var idBranch = cmbBranch.SelectedValue;

                if (int.TryParse(idBranch.ToString(), out int branchID))
                {
                    request.BranchId = branchID;
                }

                var idFuel = cmbFuelType.SelectedValue;

                if (int.TryParse(idFuel.ToString(), out int fuelid))
                {
                    request.FuelTypeId = fuelid;
                }

                var idVehicleType = cmbVehicleType.SelectedValue;

                if (int.TryParse(idVehicleType.ToString(), out int vehicletypeID))
                {
                    request.VehicleTypeId = vehicletypeID;
                }

                var idVehiclemodel = cmbVehicleModel.SelectedValue;

                if (int.TryParse(idVehiclemodel.ToString(), out int vehiclemodelID))
                {
                    request.VehicleModelId = vehiclemodelID;
                }


                var search = new VehicleSearchRequest
                {
                    RegistrationNumber = txtRegistrationNumber.Text
                };
                var list = await _serviceVehicle.Get<List<Data.Model.Vehicle>>(search);

                if (list.Count >= 1)
                {
                    MessageBox.Show("A car with this registration number already exists, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    await _serviceVehicle.Insert<Data.Model.Vehicle>(request);
                    MessageBox.Show("Operation successfully completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Image = file;
                txtImage.Text = fileName;

                Image img = Image.FromFile(fileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmbManufacturer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbManufacturer.Text))
            {
                errorProvider.SetError(cmbManufacturer, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbManufacturer, null);
            }
        }

        private void cmbVehicleModel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbVehicleModel.Text))
            {
                errorProvider.SetError(cmbVehicleModel, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbVehicleModel, null);
            }
        }

        private void cmbVehicleType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbVehicleType.Text))
            {
                errorProvider.SetError(cmbVehicleType, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbVehicleType, null);
            }
        }

        private void txtRegistrationNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrationNumber.Text))
            {
                errorProvider.SetError(txtRegistrationNumber, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtRegistrationNumber, null);
            }
        }

        private void txtVehicleNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleNumber.Text))
            {
                errorProvider.SetError(txtVehicleNumber, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtVehicleNumber, null);
            }
        }

        private void txtDailyPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDailyPrice.Text))
            {
                errorProvider.SetError(txtDailyPrice, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDailyPrice, null);
            }
        }

        private void dtDte_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtDte.Text))
            {
                errorProvider.SetError(dtDte, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtDte, null);
            }
        }

        private void cmbBranch_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbBranch.Text))
            {
                errorProvider.SetError(cmbBranch, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbBranch, null);
            }
        }

        private void txtMileage_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMileage.Text))
            {
                errorProvider.SetError(txtMileage, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMileage, null);
            }
        }

        private void txtTransmission_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTransmission.Text))
            {
                errorProvider.SetError(txtTransmission, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTransmission, null);
            }
        }

        private void cmbFuelType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbFuelType.Text))
            {
                errorProvider.SetError(cmbFuelType, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbFuelType, null);
            }
        }

        private void rtxDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxDescription.Text))
            {
                errorProvider.SetError(rtxDescription, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rtxDescription, null);
            }
        }
    }
}
