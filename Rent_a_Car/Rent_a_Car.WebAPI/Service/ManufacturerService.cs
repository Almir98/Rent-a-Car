using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.Manufacturer;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class ManufacturerService : BaseCRUDService<Data.Model.Manufacturer, ManufacturerSearchRequest, Database.Manufacturer, ManufacturerUpsert, ManufacturerUpsert>
    {
        public ManufacturerService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Data.Model.Manufacturer> Get(ManufacturerSearchRequest search)
        {
            var query = _context.Manufacturer.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.ManufacturerName))
            {
                query = query.Where(x => x.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            return _mapper.Map<List<Data.Model.Manufacturer>>(query.ToList());
        }

    }
}
