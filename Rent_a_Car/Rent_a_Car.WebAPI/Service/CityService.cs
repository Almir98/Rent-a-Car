using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.City;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class CityService : BaseService<Data.Model.City, CitySearchRequest, RentACar.WebAPI.Database.City>
    {
        public CityService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
