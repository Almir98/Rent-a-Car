using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.Branch;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class BranchController : BaseCRUDController<BranchRequest, BranchSearchRequest, BranchUpsert, BranchUpsert>
    {
        public BranchController(ICRUDService<BranchRequest, BranchSearchRequest, BranchUpsert, BranchUpsert> service) : base(service)
        {
        }
    }
}