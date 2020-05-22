using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Requests.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class BookingService : BaseCRUDService<BookingRequest, BookingSearchRequest, Booking, BookingUpsert, BookingUpsert>
    {
        public BookingService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<BookingRequest> Get(BookingSearchRequest search)
        {
            var query = _context.Set<Booking>().Include(x=>x.Customer).AsQueryable();

            if(search?.BookingId != null && search?.BookingId !=0)
            {
                query = query.Where(x => x.BookingId == search.BookingId);
            }

            if(!string.IsNullOrEmpty(search.CustomerFirstName))
            {
                query = query.Where(x => x.Customer.FirstName == search.CustomerFirstName);
            }
            query = query.OrderBy(x => x.BookingId);

            return _mapper.Map<List<BookingRequest>>(query.ToList());
        }
    }
}