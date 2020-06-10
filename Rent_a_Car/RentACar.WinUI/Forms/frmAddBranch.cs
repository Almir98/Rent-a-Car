using RentaCar.Data.Models;
using RentaCar.Data.Requests.Branch;
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
    public partial class frmAddBranch : Form
    {
        protected APIService _serviceBranch = new APIService("Branch");
        protected APIService _serviceCity = new APIService("City");

        public frmAddBranch()
        {
            InitializeComponent();
        }

        private async Task LoadCity()
        {
            var list = await _serviceCity.Get<List<City>>();
            list.Insert(0, new City());

            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";

            cmbCity.DataSource = list;
        }


        private async void frmAddBranch_Load(object sender, EventArgs e)
        {
            await LoadCity();
        }

        private async void btnSaveBranch_Click(object sender, EventArgs e)
        {
            var branch = new BranchUpsert()
            {
                BranchName = txtBranchName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Adress = txtAdress.Text,
                OpenTime = DateTime.Parse(txtOpenTime.Text),
                CloseTime = DateTime.Parse(txtClosedTime.Text),
                Description = txtDescription.Text
            };

            var idCity = cmbCity.SelectedValue;

            if (int.TryParse(idCity.ToString(), out int cityid))
            {
                branch.CityId = cityid;
            }

            await _serviceBranch.Insert<BranchRequest>(branch);
        }
    }

}
