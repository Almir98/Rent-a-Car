using RentaCar.Data.Requests.Customer;
using RentACar.WinUI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            var search = new CustomerSearchRequest()
            {
                FirstName = txtCustomer.Text
            };

            var result = await _apiService.Get<List<Data.Model.Customer>>(search);
            dgvAllCustomers.AutoGenerateColumns = false;
            dgvAllCustomers.DataSource = result;
        }

        private void dgvAllCustomers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvAllCustomers.SelectedRows[0].Cells[0].Value;
            frmCustomerDetails frm = new frmCustomerDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmAllCustomers_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<CustomerRequest>>(null);
            dgvAllCustomers.AutoGenerateColumns = false;
            dgvAllCustomers.DataSource = result;
        }

    }
}