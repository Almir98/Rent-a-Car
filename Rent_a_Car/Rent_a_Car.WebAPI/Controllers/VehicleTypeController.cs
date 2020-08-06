using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.VehicleType;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypeController : BaseController<VehicleTypeRequest, object>
    {
        public VehicleTypeController(IService<VehicleTypeRequest, object> service) : base(service)
        {
        }
    }
}