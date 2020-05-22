using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Booking;
using RentACar.WebAPI.Controllers;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Service
{
    public class BookingController : BaseCRUDController<BookingRequest, BookingSearchRequest, BookingUpsert, BookingUpsert>
    {
        public BookingController(ICRUDService<BookingRequest, BookingSearchRequest, BookingUpsert, BookingUpsert> service) : base(service)
        {
        }



    }
}