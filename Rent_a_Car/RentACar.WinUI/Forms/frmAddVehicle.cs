using RentaCar.Data.Models;
using RentaCar.Data.Requests;
using RentaCar.Data.Requests.Vehicle;
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
            var list = await _serviceManufacturer.Get<List<ManufacturerModel>>();
            list.Insert(0, new ManufacturerModel());

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
            var idObj=cmbManufacturer.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVehicleModel(id);
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var vehicle = new VehicleUpsert()
            {
                RegistrationNumber=txtRegistrationNumber.Text,
                VehicleNumber=int.Parse(txtVehicleNumber.Text),
                DailyPrice=double.Parse(txtDailyPrice.Text),
                Description=rtxDescription.Text,
                ManufacturerDate=dtDte.Value,
                Mileage=txtMileage.Text,
                Transmission=txtTransmission.Text,
                NumberOfSeats=int.Parse(txtNumberOfSeats.Text),
                Status=chkStatus.Checked
            };

            // ove foreign moraju se posebno parsat
            //branch
            var idBranch = cmbBranch.SelectedValue;

            if(int.TryParse(idBranch.ToString(),out int branchID))
            {
                vehicle.BranchId = branchID;
            }

            //fueltype
            var idFuel = cmbFuelType.SelectedValue;

            if(int.TryParse(idFuel.ToString(),out int fuelid))
            {
                vehicle.FuelTypeId = fuelid;
            }

            // vehicletype
            var idVehicleType = cmbVehicleType.SelectedValue;

            if(int.TryParse(idVehicleType.ToString(),out int vehicletypeID))
            {
                vehicle.VehicleTypeId = vehicletypeID;
            }

            //vehiclemodel
            var idVehiclemodel = cmbVehicleType.SelectedValue;

            if (int.TryParse(idVehiclemodel.ToString(), out int vehiclemodelID))
            {
                vehicle.VehicleModelId = vehiclemodelID;
            }
            
            await _serviceVehicle.Insert<VehicleRequest>(vehicle);
        }

    }
}
