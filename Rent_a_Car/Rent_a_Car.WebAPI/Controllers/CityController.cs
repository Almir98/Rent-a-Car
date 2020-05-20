using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.City;

namespace Rent_a_Car.WebAPI.Controllers
{
    public class CityController : BaseController<CityRequest, object>
    {
        public CityController(IService<CityRequest, object> service) : base(service)
        {
        }
    }
}