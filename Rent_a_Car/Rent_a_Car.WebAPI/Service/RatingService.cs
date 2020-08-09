using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentaCar.Data.Requests.Rating;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class RatingService : BaseCRUDService<Data.Model.Rating, RatingSearchRequest, Rating, RatingUpsert, RatingUpsert>
    {
        public RatingService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Data.Model.Rating> Get(RatingSearchRequest search)
        {
            var query = _context.Set<WebAPI.Database.Rating>()
                .Include(x => x.Customer)
                .Include(e => e.Vehicle)
                .Include(e => e.Vehicle.VehicleModel)
                .Include(e => e.Vehicle.VehicleModel.Manufacturer)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            
            query = query.OrderBy(x => x.RatingValue);

            return _mapper.Map<List<Data.Model.Rating>>(query.ToList());
        }

        public override Data.Model.Rating GetByID(int id)
        {
            var rating = _context.Rating
                .Include(e => e.Customer)
                .Include(e => e.Vehicle)
                .Include(e => e.Customer.City)
                .Include(e=>e.Vehicle.VehicleModel)
                .Include(e=>e.Vehicle.VehicleModel.Manufacturer)
                .FirstOrDefault(e => e.RatingId == id);

            return _mapper.Map<Data.Model.Rating>(rating);
        }

    }
}
