using RentaCar.Data.Requests.Comments;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RentACar.WinUI.Forms
{
    public partial class frmCommentDetails : Form
    {
        protected readonly APIService _serviceComment = new APIService("Comment");
        private int? _id = null;

        public frmCommentDetails(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private async void frmCommentDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var comment = await _serviceComment.GetById<CommentRequest>(_id);

                txtComment.Text = comment.CommentId.ToString();
                txtFirstName.Text = comment.Customer.FirstName;
                txtLastName.Text = comment.Customer.LastName;
                dtComment.Value = comment.DateOfComment;
                txtDescritpion.Text = comment.Description;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Report 

        PrintPreviewDialog printPreview = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        
        private void btnPrintRating_Click(object sender, EventArgs e)
        {
            Print(this.panelPrinting3);
        }

        public void Print(Panel panelPrinting)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrinting3 = panelPrinting;
            GetPrintingArea(panelPrinting);
            printPreview.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);
            printPreview.ShowDialog();
        }

        public void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (this.panelPrinting3.Width / 2), this.panelPrinting3.Location.Y);
        }

        Bitmap memoryImage;
        public void GetPrintingArea(Panel panelPrinting)
        {
            memoryImage = new Bitmap(panelPrinting.Width, panelPrinting.Height);
            panelPrinting.DrawToBitmap(memoryImage, new Rectangle(0, 0, panelPrinting.Width, panelPrinting.Height));
        }
    }
}
