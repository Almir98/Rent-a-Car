using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.VehicleModel;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class VehicleModelService : BaseService<Data.Model.VehicleModel, VehicleModelSearch, VehicleModel>
    {
        public VehicleModelService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Data.Model.VehicleModel> Get(VehicleModelSearch search)
        {
            var query = _context.VehicleModel.AsQueryable();

            if (search?.ManufacturerId.HasValue == true)
            {
                query = query.Where(e => e.ManufacturerId == search.ManufacturerId);
            }
            query.OrderBy(x => x.ModelName);

            return _mapper.Map<List<Data.Model.VehicleModel>>(query.ToList());
        }
    }
}
