using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.VehicleModel;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : BaseController<VehicleModelRequest, VehicleModelSearch>
    {
        public VehicleModelController(IService<VehicleModelRequest, VehicleModelSearch> service) : base(service)
        {
        }
    }
}