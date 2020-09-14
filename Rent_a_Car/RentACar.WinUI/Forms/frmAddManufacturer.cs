using RentaCar.Data.Requests.Manufacturer;
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
    public partial class frmAddManufacturer : Form
    {
        protected APIService _serviceManufacturer = new APIService("Manufacturer");

        public frmAddManufacturer()
        {
            InitializeComponent();
        }

        private async void btnSaveManufacturer_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var manufacturer = new ManufacturerUpsert()
                {
                    ManufacturerName=txtManufacturerName.Text
                };

                var request = new ManufacturerSearchRequest{
                    ManufacturerName = txtManufacturerName.Text
                };
                var list = await _serviceManufacturer.Get<List<Data.Model.Manufacturer>>(request);

                if (list.Count >= 1)
                {
                    MessageBox.Show("This manufacturer name has already been entered.Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    await _serviceManufacturer.Insert<Data.Model.Manufacturer>(manufacturer);
                    MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void txtManufacturerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtManufacturerName.Text))
            {
                errorProvider1.SetError(txtManufacturerName, " Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtManufacturerName, null);
            }
        }
    }
}
