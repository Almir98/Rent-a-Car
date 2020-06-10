﻿using RentaCar.Data.Models;
using RentaCar.Data.Requests.Comments;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    ManufacturerName = item.Vehicle.VehicleModel.Manufacturer.ManufacturerName
                };
                newList.Add(form);
            }
            newList = newList.OrderBy(x => x.DateOfComment).ToList();
            dgvComments.DataSource = newList;

        }

        private async void btnSearch_Click(object sender, EventArgs e)          // ne radi dobro
        {
            var search = new CommentSearchRequest()
            {
                ManufacturerName = txtSearch.Text,
            };

            var result = await _serviceComments.Get<List<MComment>>(search);
            dgvComments.AutoGenerateColumns = false;
            dgvComments.DataSource = result;
        }
    }
}