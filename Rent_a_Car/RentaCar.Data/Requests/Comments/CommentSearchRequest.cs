﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Comments
{
    public class CommentSearchRequest
    {
        public string CustomerFirstName { get; set; }
        public string ManufacturerName { get; set; }
    }
}
