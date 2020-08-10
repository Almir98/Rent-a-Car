using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Recommend;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendController : ControllerBase
    {
        private readonly IRecommendService _service;

        public RecommendController(IRecommendService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Data.Model.Vehicle> RecommendProduct([FromQuery]RecommendSearchRequest request)
        {
            return _service.RecommendVehicle(request.VehicleId);
        }
    }
}