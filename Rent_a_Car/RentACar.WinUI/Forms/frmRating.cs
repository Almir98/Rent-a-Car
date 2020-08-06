using RentaCar.Data.Requests.Rating;
using RentaCar.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmRating : Form
    {
        protected readonly APIService _serviceRating = new APIService("Rating");

        public frmRating()
        {
            InitializeComponent();
        }

        private async void frmRating_Load(object sender, EventArgs e)
        {
            var list = await _serviceRating.Get<List<RatingRequest>>(null);
             
            List<frmRatingVM> newList = new List<frmRatingVM>();

            foreach (var item in list)
            {
                frmRatingVM form = new frmRatingVM
                {
                    RatingId = item.RatingId,
                    RatingValue = item.RatingValue,
                    FirstName = item.Customer.FirstName,
                    LastName = item.Customer.LastName,
                    Username = item.Customer.Username,
                    RegistrationNumber = item.Vehicle.RegistrationNumber,
                    ModelName = item.Vehicle.VehicleModel.ModelName,
                    ManufacturerName = item.Vehicle.VehicleModel.Manufacturer.ManufacturerName
                };
                newList.Add(form);
            }
            newList = newList.OrderBy(x => x.RatingValue).ToList();

            float totalRating = 0;
            int i = 0;
            foreach (var item in newList)
            {
                totalRating += item.RatingValue;
                i++;
            }
            totalRating =totalRating/i;
            txtSelected.Text = totalRating.ToString();

            dgvRating.AutoGenerateColumns = false;
            dgvRating.DataSource = newList;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new RatingSearchRequest()
            {
                ManufacturerName = txtVehicle.Text,
            };
            var list = await _serviceRating.Get<List<RatingRequest>>(search);
        }

        private void dgvRating_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvRating.SelectedRows[0].Cells[0].Value;
            frmRatingDetails frm = new frmRatingDetails(int.Parse(id.ToString()));
            frm.Show();
        }


        // Report 

        PrintPreviewDialog printPreview = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        
        private void btnPrintRating_Click(object sender, EventArgs e)
        {
            Print(this.panelPrinting1);
        }

        public void Print(Panel panelPrinting)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrinting1 = panelPrinting;
            GetPrintingArea(panelPrinting);
            printPreview.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);
            printPreview.ShowDialog();
        }

        public void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (this.panelPrinting1.Width / 2), this.panelPrinting1.Location.Y);
        }

        Bitmap memoryImage;
        public void GetPrintingArea(Panel panelPrinting)
        {
            memoryImage = new Bitmap(panelPrinting.Width, panelPrinting.Height);
            panelPrinting.DrawToBitmap(memoryImage, new Rectangle(0, 0, panelPrinting.Width, panelPrinting.Height));
        }
    }
}
