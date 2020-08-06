using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Fuel_type;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeController : BaseController<FuelTypeRequest, object>
    {
        public FuelTypeController(IService<FuelTypeRequest, object> service) : base(service)
        {
        }
    }
}