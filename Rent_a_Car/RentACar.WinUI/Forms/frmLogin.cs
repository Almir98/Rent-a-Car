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

                await _apiService.Get<dynamic>(null);

                frmIndex frm = new frmIndex();
                frm.Show();
                this.Hide();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
