using Data.Model;
using RentaCar.Data.Requests.Customer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Customer");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                    APIService.Username = txtUsername.Text;
                    APIService.Password = txtPassword.Text;

                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)){
                    MessageBox.Show("All fields are required! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var request = new CustomerSearchRequest{
                    Username=txtUsername.Text
                };
                var customer=await _apiService.Get<List<Data.Model.Customer>>(request);
                if(customer.Count==0){
                    MessageBox.Show("Customer with this credentials don't exist! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else{
                    frmIndex frm = new frmIndex();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Wrong username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
