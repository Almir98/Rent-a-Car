using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Manufacturer;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class ManufacturerController : BaseCRUDController<Data.Model.Manufacturer, ManufacturerSearchRequest, ManufacturerUpsert, ManufacturerUpsert>
    {
        public ManufacturerController(ICRUDService<Manufacturer, ManufacturerSearchRequest, ManufacturerUpsert, ManufacturerUpsert> service) : base(service)
        {
        }
    }
}