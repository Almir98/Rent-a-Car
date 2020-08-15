using Data.Model;
using RentaCar.Data.Requests.Branch;
using System;
using System.Collections.Generic;
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
            if (this.ValidateChildren())
            {
                var branch = new BranchUpsert()
                {
                    BranchName = txtBranchName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Adress = txtAdress.Text,
                    OpenTime = txtOpenTime.Text,
                    CloseTime = txtClosedTime.Text,
                    Description = txtDescription.Text
                };

                var idCity = cmbCity.SelectedValue;

                if (int.TryParse(idCity.ToString(), out int cityid))
                {
                    branch.CityId = cityid;
                }

                await _serviceBranch.Insert<Data.Model.Branch>(branch);
                MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtBranchName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBranchName.Text))
            {
                errorProvider.SetError(txtBranchName, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBranchName, null);
            }
        }

        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBranchName, null);
            }
        }

        private void txtAdress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdress.Text))
            {
                errorProvider.SetError(txtAdress, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAdress, null);
            }
        }

        private void txtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescription, null);
            }
        }

        private void cmbCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCity.Text))
            {
                errorProvider.SetError(cmbCity, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbCity, null);
            }
        }

        private void txtOpenTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpenTime.Text))
            {
                errorProvider.SetError(txtOpenTime, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpenTime, null);
            }
        }

        private void txtClosedTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClosedTime.Text))
            {
                errorProvider.SetError(txtClosedTime, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtClosedTime, null);
            }
        }
    }
}
