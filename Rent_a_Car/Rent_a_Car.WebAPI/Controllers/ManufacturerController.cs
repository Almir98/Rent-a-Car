using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Manufacturer;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : BaseController<Data.Model.Manufacturer, object>
    {
        public ManufacturerController(IService<Manufacturer, object> service) : base(service)
        {
        }
    }
}