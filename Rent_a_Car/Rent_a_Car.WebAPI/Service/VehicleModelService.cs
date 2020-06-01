using AutoMapper;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.VehicleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class VehicleModelService : BaseService<VehicleModelRequest, VehicleModelSearch, VehicleModel>
    {
        public VehicleModelService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<VehicleModelRequest> Get(VehicleModelSearch search)
        {
            var query = _context.VehicleModel.AsQueryable();

            if(search?.ManufacturerId.HasValue==true)
            {
                query = query.Where(e => e.ManufacturerId == search.ManufacturerId);
            }
            query.OrderBy(x => x.ModelName);

            return _mapper.Map<List<VehicleModelRequest>>(query.ToList());
        }

    }
}
