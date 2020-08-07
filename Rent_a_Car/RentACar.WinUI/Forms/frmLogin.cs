using System;
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
                if (this.ValidateChildren())
                {

                    APIService.Username = txtUsername.Text;
                    APIService.Password = txtPassword.Text;

                    await _apiService.Get<dynamic>(null);

                    frmIndex frm = new frmIndex();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text.Length < 4)
            {
                errorProvider.SetError(txtPassword, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}
