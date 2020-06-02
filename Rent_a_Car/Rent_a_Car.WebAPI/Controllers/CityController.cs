using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Branch;
using RentaCar.Data.Requests.City;
using RentACar.WebAPI.Controllers;
using RentACar.WebAPI.Interface;

namespace Rent_a_Car.WebAPI.Controllers
{
    public class CityController : BaseController<CityRequest, CitySearchRequest>
    {
        public CityController(IService<CityRequest, CitySearchRequest> service) : base(service)
        {
        }
    }
}