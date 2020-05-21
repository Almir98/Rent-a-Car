using AutoMapper;
using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Requests.Branch;
using RentaCar.Data.Requests.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_a_Car.WebAPI.Mappers
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<City, CityRequest>().ReverseMap();
            CreateMap<Branch, BranchRequest>().ReverseMap();
            CreateMap<BranchRequest, BranchSearchRequest>().ReverseMap();
            CreateMap<Branch, BranchUpsert>().ReverseMap();

            CreateMap<City, CityUpsert>().ReverseMap();
            CreateMap<City, CitySearchRequest>().ReverseMap();




        }
    }
}
