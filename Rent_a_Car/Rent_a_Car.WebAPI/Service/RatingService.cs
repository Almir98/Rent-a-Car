using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Requests.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class RatingService : BaseCRUDService<RatingRequest, RatingSearchRequest, Rating, RatingUpsert, RatingUpsert>
    {
        public RatingService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<RatingRequest> Get(RatingSearchRequest search)
        {
            var query = _context.Set<Rating>()
                .Include(x => x.Customer)
                .Include(e => e.Vehicle)
                .Include(e => e.Vehicle.VehicleModel)
                .Include(e => e.Vehicle.VehicleModel.Manufacturer)
                .AsQueryable();

            if(!string.IsNullOrWhiteSpace(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            query = query.OrderBy(x => x.RatingValue);

            return _mapper.Map<List<RatingRequest>>(query.ToList());
        }
    }
}
