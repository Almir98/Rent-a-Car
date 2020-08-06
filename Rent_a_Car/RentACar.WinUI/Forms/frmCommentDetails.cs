using RentaCar.Data.Requests.Comments;
using System;
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
    }
}
