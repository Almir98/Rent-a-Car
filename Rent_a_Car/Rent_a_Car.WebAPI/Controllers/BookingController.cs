using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Booking;
using RentACar.WebAPI.Controllers;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Service
{
    public class BookingController : BaseCRUDController<Data.Model.Booking, BookingSearchRequest, BookingUpsert, BookingUpsert>
    {
        public BookingController(ICRUDService<Booking, BookingSearchRequest, BookingUpsert, BookingUpsert> service) : base(service)
        {
        }
    }
}