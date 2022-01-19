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
            var query = _context.Set<Vehicle>()
                .Include(x => x.VehicleModel)
                .Include(e=>e.VehicleModel.Manufacturer)
                .Include(e=>e.FuelType)
                .Include(e => e.Branch)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            
            if (!string.IsNullOrEmpty(search.RegistrationNumber))
            {
                query = query.Where(x => x.RegistrationNumber.StartsWith(search.RegistrationNumber));
            }

            if (!string.IsNullOrEmpty(search.Transmission))
            {
                query = query.Where(x => x.Transmission.StartsWith(search.Transmission));
            }

            if (!string.IsNullOrEmpty(search.BranchName))     // for xamarin and desktop
            {
                query = query.Where(x => x.Branch.BranchName.StartsWith(search.BranchName));
            }

            if (!string.IsNullOrEmpty(search.ModelName))
            {
                query = query.Where(x => x.VehicleModel.ModelName.StartsWith(search.ModelName));
            }

            if (!string.IsNullOrEmpty(search.FuelName))
            {
                query = query.Where(x => x.FuelType.FuelName.StartsWith(search.FuelName));
            }

            query = query.OrderBy(x => x.VehicleModel.Manufacturer.ManufacturerName);

            return _mapper.Map<List<Data.Model.Vehicle>>(query.ToList());
        }

        public override Data.Model.Vehicle GetByID(int id)
        {
            var vehicle = _context.Vehicle.Include(e => e.VehicleModel).Include(e => e.VehicleModel.Manufacturer)
                .Include(e => e.FuelType)
                .Include(e => e.Branch).FirstOrDefault(a => a.VehicleId == id);

            return _mapper.Map<Data.Model.Vehicle>(vehicle);
        }
    }
}
