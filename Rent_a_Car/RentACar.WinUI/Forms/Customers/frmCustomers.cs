using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using RentaCar.Data.Requests.Customer;

namespace RentACar.WinUI
{
    public partial class frmAllCustomers : Form
    {
        private readonly APIService _apiService = new APIService("Customer");

        public frmAllCustomers()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var result =await _apiService.Get<List<CustomerRequest>>();
            dgvAllCustomers.DataSource = result;
        }
    }
}
