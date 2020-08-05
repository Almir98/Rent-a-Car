using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.City;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class CityService : BaseService<CityRequest, CitySearchRequest, RentACar.WebAPI.Database.City>
    {
        public CityService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<CityRequest> Get(CitySearchRequest search)
        {
            var query = _context.Set<City>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.CityName))
            {
                query = query.Where(x => x.CityName.StartsWith(search.CityName));
            }
            query = query.OrderBy(x => x.CityName);

            return _mapper.Map<List<CityRequest>>(query.ToList());
        }
    }
}
