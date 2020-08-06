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
            var query = _context.Set<Booking>().Include(x => x.Customer)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search.FirstName))
            {
                query = query.Where(x => x.Customer.FirstName.StartsWith(search.FirstName));
            }
            query = query.OrderBy(x => x.BookingId);

            return _mapper.Map<List<Data.Model.Booking>>(query.ToList());
        }

        public override Data.Model.Booking GetByID(int id)
        {
            var booking = _context.Booking.Where(e => e.BookingId == id)
                .Include(e => e.Customer)
                .FirstOrDefault();

            return _mapper.Map<Data.Model.Booking>(booking);
        }

    }
}