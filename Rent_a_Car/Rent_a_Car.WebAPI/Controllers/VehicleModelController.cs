using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.VehicleModel;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class VehicleModelController : BaseCRUDController<Data.Model.VehicleModel, VehicleModelSearch, VehicleModelUpsert, VehicleModelUpsert>
    {
        public VehicleModelController(ICRUDService<VehicleModel, VehicleModelSearch, VehicleModelUpsert, VehicleModelUpsert> service) : base(service)
        {
        }
    }
}