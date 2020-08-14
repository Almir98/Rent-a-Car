using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentaCar.Data.Requests.Booking;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class BookingService : BaseCRUDService<Data.Model.Booking, BookingSearchRequest, RentACar.WebAPI.Database.Booking, BookingUpsert, BookingUpsert>
    {
        public BookingService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Data.Model.Booking> Get(BookingSearchRequest search)
        {
            var query = _context.Set<Database.Booking>().Include(x => x.Customer)
                .Include(e=>e.Vehicle)
                .Include(e=>e.Vehicle.VehicleModel)
                .Include(e=>e.Vehicle.VehicleModel.Manufacturer)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search.FirstName))
            {
                query = query.Where(x => x.Customer.FirstName.StartsWith(search.FirstName));
            }

            if (search?.CustomerID.HasValue == true)
            {
                query = query.Where(x => x.Customer.CustomerId == search.CustomerID);
            }

            if (search?.VehicleID.HasValue == true)
            {
                query = query.Where(x => x.Vehicle.VehicleId == search.VehicleID);
            }

            query = query.OrderBy(x => x.BookingId);

            return _mapper.Map<List<Data.Model.Booking>>(query.ToList());
        }


        public override Data.Model.Booking GetByID(int id)
        {
            var booking = _context.Booking
                .Include(e => e.Customer)
                .Include(e => e.Vehicle)
                .Include(e => e.Vehicle.VehicleModel)
                .Include(e => e.Vehicle.VehicleModel.Manufacturer)
                .FirstOrDefault(e => e.BookingId == id);

            return _mapper.Map<Data.Model.Booking>(booking);
        }

    }
}