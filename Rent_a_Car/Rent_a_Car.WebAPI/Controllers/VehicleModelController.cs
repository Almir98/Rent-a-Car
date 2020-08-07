using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.VehicleModel;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : BaseController<Data.Model.VehicleModel, VehicleModelSearch>
    {
        public VehicleModelController(IService<VehicleModel, VehicleModelSearch> service) : base(service)
        {
        }
    }
}