using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests;
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