using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Branch;

namespace RentACar.WebAPI.Controllers
{
    public class BranchController : BaseController<BranchRequest, object>
    {
        public BranchController(IService<BranchRequest, object> service) : base(service)
        {
        }
    }
}