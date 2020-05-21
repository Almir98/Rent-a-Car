using AutoMapper;
using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Requests.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class CityService : BaseCRUDService<CityRequest, CitySearchRequest, City, CityUpsert, CityUpsert>
    {
        public CityService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<CityRequest> Get(CitySearchRequest search)
        {
            var query = _context.Set<City>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.CityName) || !string.IsNullOrWhiteSpace(search.PostCode))
            {
                query = query.Where(x => x.CityName.StartsWith(search.CityName) || x.PostCode.StartsWith(search.PostCode));
            }
            query = query.OrderBy(x => x.CityName);

            return _mapper.Map<List<CityRequest>>(query.ToList());
        }
    }
}
