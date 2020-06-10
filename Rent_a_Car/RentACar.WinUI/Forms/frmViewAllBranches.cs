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
            var list = await _serviceCity.Get<List<City>>();
            list.Insert(0, new City());

            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";

            cmbCity.DataSource = list;
        }

        private async void frmViewAllBranches_Load(object sender, EventArgs e)
        {
            await LoadCity();
        }

        private async void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idstr=cmbCity.SelectedValue;

            if(int.TryParse(idstr.ToString(),out int id))
            {
                await LoadBranch(id);
            }
        }

        private async Task LoadBranch(int cityID)
        {
            var result = await _apiService.Get<List<BranchRequest>>(new BranchSearchRequest
            {
                CityId = cityID
            });

            dgvBranch.DataSource = result;
        }

    }
}
