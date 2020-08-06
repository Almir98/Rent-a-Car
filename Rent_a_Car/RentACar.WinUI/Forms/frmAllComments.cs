using Data.Model;
using RentaCar.Data.Requests.Comments;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RentACar.WinUI.Forms
{
    public partial class frmAllComments : Form
    {
        APIService _serviceComments = new APIService("Comment");
        APIService _serviceCustomer = new APIService("Customer");

        private Customer _customer;

        public frmAllComments(Customer customer = null)
        {
            _customer = customer;
            InitializeComponent();
        }

        private async void frmAllComments_Load(object sender, EventArgs e)
        {
            var list = await _serviceComments.Get<List<CommentRequest>>(null);

            List<frmAllCommentsVM> newList = new List<frmAllCommentsVM>();

            foreach (var item in list)
            {
                frmAllCommentsVM form = new frmAllCommentsVM
                {
                    CommentId = item.CommentId,
                    Description = item.Description,
                    DateOfComment = item.DateOfComment,
                    FirstName = item.Customer.FirstName,
                    LastName = item.Customer.LastName,
                    ManufacturerName = item.Vehicle.VehicleModel.Manufacturer.ManufacturerName,
                    ModelName = item.Vehicle.VehicleModel.ModelName
                };
                newList.Add(form);
            }
            newList = newList.OrderBy(x => x.DateOfComment).ToList();
            dgvComments.AutoGenerateColumns = false;
            dgvComments.DataSource = newList;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new CommentSearchRequest()
            {
                ManufacturerName = txtSearch.Text,
            };

            var result = await _serviceComments.Get<List<CommentRequest>>(search);
            dgvComments.AutoGenerateColumns = false;
            dgvComments.DataSource = result;
        }

        private void dgvComments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvComments.SelectedRows[0].Cells[0].Value;
            frmCommentDetails frm = new frmCommentDetails(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
