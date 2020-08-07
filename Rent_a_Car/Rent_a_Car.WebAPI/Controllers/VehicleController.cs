using Data.Model;
using RentaCar.Data.Requests.Vehicle;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class VehicleController : BaseCRUDController<Data.Model.Vehicle, VehicleSearchRequest, VehicleUpsert, VehicleUpsert>
    {
        public VehicleController(ICRUDService<Vehicle, VehicleSearchRequest, VehicleUpsert, VehicleUpsert> service) : base(service)
        {
        }
    }
}