using Data.Model;
using RentaCar.Data.Requests.Comments;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
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
            var list = await _serviceComments.Get<List<Data.Model.Comment>>(null);

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
            var resultList = await _serviceComments.Get<List<Data.Model.Comment>>(search);
            
            List<frmAllCommentsVM> finalList = new List<frmAllCommentsVM>();

            foreach (var item in resultList)
            {
                frmAllCommentsVM form = new frmAllCommentsVM
                {
                    CommentId=item.CommentId,
                    Description=item.Description,
                    DateOfComment=item.DateOfComment,
                    FirstName=item.Customer.FirstName,
                    LastName=item.Customer.LastName,
                    ManufacturerName=item.Vehicle.VehicleModel.Manufacturer.ManufacturerName,
                    ModelName=item.Vehicle.VehicleModel.ModelName
                };
                finalList.Add(form);
            }
            dgvComments.AutoGenerateColumns = false;
            dgvComments.DataSource = finalList;
        }

        private void dgvComments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvComments.SelectedRows[0].Cells[0].Value;
            frmCommentDetails frm = new frmCommentDetails(int.Parse(id.ToString()));
            frm.Show();
        }

        // Report 

        PrintPreviewDialog printPreview = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();

        private void btnPrintRating_Click(object sender, EventArgs e)
        {
            Print(this.panelPrinting2);
        }

        public void Print(Panel panelPrinting)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrinting2 = panelPrinting;
            GetPrintingArea(panelPrinting);
            printPreview.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);
            printPreview.ShowDialog();
        }

        public void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (this.panelPrinting2.Width / 2), this.panelPrinting2.Location.Y);
        }

        Bitmap memoryImage;
        public void GetPrintingArea(Panel panelPrinting)
        {
            memoryImage = new Bitmap(panelPrinting.Width, panelPrinting.Height);
            panelPrinting.DrawToBitmap(memoryImage, new Rectangle(0, 0, panelPrinting.Width, panelPrinting.Height));
        }
    }
}
