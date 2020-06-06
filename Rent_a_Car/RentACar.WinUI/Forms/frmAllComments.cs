using Rent_a_Car.WebAPI.Models;
using RentaCar.Data.ViewModel;
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
    public partial class frmAllComments : Form
    {
        APIService _serviceComments = new APIService("Comment");
        APIService _serviceCustomer = new APIService("Customer");

        private Customer _customer;

        public frmAllComments(Customer customer=null)
        {
            _customer = customer;
            InitializeComponent();
        }

        private async void frmAllComments_Load(object sender, EventArgs e)
        {
            var list = await _serviceComments.Get<List<MComment>>(null);

            List<frmAllCommentsVM> vm = new List<frmAllCommentsVM>();

            foreach (var item in list)
            {
                frmAllCommentsVM form = new frmAllCommentsVM
                {
                    CommentId=item.CommentId,
                    Description=item.Description,
                    DateOfComment=item.DateOfComment,
                    FirstName=item.Customer.FirstName,
                    LastName=item.Customer.LastName,
                    ManufacturerName=item.Vehicle.VehicleModel.Manufacturer.ManufacturerName
                };
                vm.Add(form);
            }
            vm = vm.OrderBy(x => x.DateOfComment).ToList();
            dgvComments.DataSource = list;
        }
    }
}
