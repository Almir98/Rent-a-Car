using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentaCar.Data.Requests.Vehicle;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class VehicleService : BaseCRUDService<Data.Model.Vehicle, VehicleSearchRequest, Vehicle, VehicleUpsert, VehicleUpsert>
    {
        public VehicleService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Data.Model.Vehicle> Get(VehicleSearchRequest search)
        {
            var query = _context.Vehicle.Include(x => x.VehicleModel)
                .Include(e=>e.VehicleModel.Manufacturer)
                .Include(e=>e.FuelType)
                .Include(e => e.Branch)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            query = query.OrderBy(x => x.VehicleNumber);

            return _mapper.Map<List<Data.Model.Vehicle>>(query.ToList());
        }

        public override Data.Model.Vehicle GetByID(int id)
        {
            var vehicle = _context.Vehicle.Include(e => e.VehicleModel).Include(e => e.VehicleModel.Manufacturer).FirstOrDefault(a => a.VehicleId == id);

            return _mapper.Map<Data.Model.Vehicle>(vehicle);
        }
    }
}
