using System;

namespace RentaCar.Data.ViewModel
{
    public class frmAllCommentsVM
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime DateOfComment { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelName { get; set; }
    }
}
