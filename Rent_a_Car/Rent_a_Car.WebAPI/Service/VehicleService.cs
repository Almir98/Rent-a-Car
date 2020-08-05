using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentaCar.Data.Requests;
using RentaCar.Data.Requests.Vehicle;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class VehicleService : BaseCRUDService<VehicleRequest, VehicleSearchRequest, Vehicle, VehicleUpsert, VehicleUpsert>
    {
        public VehicleService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<VehicleRequest> Get(VehicleSearchRequest search)
        {
            var query = _context.Set<Vehicle>().Include(x=>x.VehicleModel.Manufacturer).Include(x=>x.Branch).AsQueryable();

            if(!string.IsNullOrEmpty(search.BranchName))
            {
                query = query.Where(x => x.Branch.BranchName == search.BranchName);
            }

            if (!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.VehicleModel.Manufacturer.ManufacturerName == search.ManufacturerName);
            }
            if (!string.IsNullOrEmpty(search.RegistrationNumber))
            {
                query = query.Where(x => x.RegistrationNumber == search.RegistrationNumber);
            }
            query = query.OrderBy(x => x.VehicleNumber);

            return _mapper.Map<List<VehicleRequest>>(query.ToList());
        }
    }
}
