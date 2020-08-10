using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeController : BaseController<Data.Model.FuelType, object>
    {
        public FuelTypeController(IService<FuelType, object> service) : base(service)
        {
        }
    }
}