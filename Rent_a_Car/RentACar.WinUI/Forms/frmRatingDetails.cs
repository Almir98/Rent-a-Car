using RentaCar.Data.Requests.Rating;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmRatingDetails : Form
    {
        protected readonly APIService _serviceRating = new APIService("Rating");
        private int? _id = null;

        public frmRatingDetails(int? id)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmRatingDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var rating = await _serviceRating.GetById<Data.Model.Rating>(_id);

                txtFirstName.Text = rating.Customer.FirstName;
                txtLastName.Text = rating.Customer.LastName;
                txtUsername.Text = rating.Customer.Username;
                txtCity.Text = rating.Customer.City.CityName;
                txtManufacturer.Text = rating.Vehicle.VehicleModel.Manufacturer.ManufacturerName;
                txtModelName.Text = rating.Vehicle.VehicleModel.ModelName;
                txtRegistrationNumber.Text = rating.Vehicle.RegistrationNumber;
                txtRatingValue.Text = rating.RatingValue.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        PrintPreviewDialog printPreview = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel3);
        }

        public void Print(Panel panelPrinting)
        {
            PrinterSettings ps = new PrinterSettings();
            panel3 = panelPrinting;
            GetPrintingArea(panelPrinting);
            printPreview.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);
            printPreview.ShowDialog();
        }

        public void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (this.panel3.Width / 2), this.panel3.Location.Y);
        }

        Bitmap memoryImage;
        public void GetPrintingArea(Panel panelPrinting)
        {
            memoryImage = new Bitmap(panelPrinting.Width, panelPrinting.Height);
            panelPrinting.DrawToBitmap(memoryImage, new Rectangle(0, 0, panelPrinting.Width, panelPrinting.Height));
        }




    }
}
