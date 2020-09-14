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

            if (search?.RatingValue.HasValue==true)
            {
                query = query.Where(x => x.RatingValue == search.RatingValue);
            }

            if (!string.IsNullOrWhiteSpace(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }

            if (!string.IsNullOrWhiteSpace(search.ModelName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.ModelName.StartsWith(search.ModelName));
            }

            if (!string.IsNullOrWhiteSpace(search.FirstName))
            {
                query = query.Where(x => x.Customer.FirstName.StartsWith(search.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(search.LastName))
            {
                query = query.Where(x => x.Customer.LastName.StartsWith(search.LastName));
            }

            if (search?.CustomerID.HasValue == true)
            {
                query = query.Where(x => x.Customer.CustomerId == search.CustomerID);
            }

            if (search.VehicleId.HasValue == true)
            {
                query = query.Where(x => x.Vehicle.VehicleId == search.VehicleId);
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
