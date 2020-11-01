using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class CustomerTypeController : BaseController<Data.Model.CustomerType, object>
    {
        public CustomerTypeController(IService<CustomerType, object> service) : base(service)
        {
        }
    }
}