using Data.Model;
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