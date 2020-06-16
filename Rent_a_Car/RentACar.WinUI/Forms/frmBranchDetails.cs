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
    public partial class frmBranchDetails : Form
    {
        protected readonly APIService _serviceBranch = new APIService("Branch");
        private int? _id=null;

        public frmBranchDetails(int? id)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmBranchDetails_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var branch = await _serviceBranch.GetById<BranchRequest>(_id);

                txtBranchName.Text = branch.BranchName;
                txtAdress.Text = branch.Adress;
                txtPhoneNumber.Text = branch.PhoneNumber;
                txtOpenTime.Text = branch.OpenTime.ToString();
                txtCloseTime.Text = branch.CloseTime.ToString();
                txtDescription.Text = branch.Description;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
