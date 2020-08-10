﻿using Data.Model;
using RentaCar.Data.Requests.Branch;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmViewAllBranches : Form
    {
        private readonly APIService _apiService = new APIService("Branch");
        protected APIService _serviceCity = new APIService("City");


        public frmViewAllBranches()
        {
            InitializeComponent();
        }

        private async Task LoadCity()
        {
            var list = await _serviceCity.Get<List<Data.Model.City>>();
            list.Insert(0, new City());

            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";

            cmbCity.DataSource = list;
        }

        private async void frmViewAllBranches_Load(object sender, EventArgs e)
        {
            await LoadCity();

            var result = await _apiService.Get<List<Data.Model.Branch>>(null);
            dgvBranch.AutoGenerateColumns = false;
            dgvBranch.DataSource = result;
        }

        private async void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idstr = cmbCity.SelectedValue;

            if (int.TryParse(idstr.ToString(), out int id))
            {
                await LoadBranch(id);
            }
        }

        private async Task LoadBranch(int cityID)
        {
            var result = await _apiService.Get<List<Data.Model.Branch>>(new BranchSearchRequest
            {
                CityId = cityID
            });

            dgvBranch.AutoGenerateColumns = false;
            dgvBranch.DataSource = result;
        }

        private void dgvBranch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvBranch.SelectedRows[0].Cells[0].Value;
            frmBranchDetails frm = new frmBranchDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
