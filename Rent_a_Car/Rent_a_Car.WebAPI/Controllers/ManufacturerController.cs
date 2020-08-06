using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Manufacturer;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : BaseController<ManufacturerRequest, object>
    {
        public ManufacturerController(IService<ManufacturerRequest, object> service) : base(service)
        {
        }
    }
}