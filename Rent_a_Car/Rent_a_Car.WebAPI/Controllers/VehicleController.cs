using RentaCar.Data.Requests.Vehicle;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class VehicleController : BaseCRUDController<VehicleRequest, VehicleSearchRequest, VehicleUpsert, VehicleUpsert>
    {
        public VehicleController(ICRUDService<VehicleRequest, VehicleSearchRequest, VehicleUpsert, VehicleUpsert> service) : base(service)
        {
        }
    }
}