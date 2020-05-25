using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Customer;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<CustomerRequest>> Get([FromQuery]CustomerSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public ActionResult<CustomerRequest> Insert(CustomerUpsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public ActionResult<CustomerRequest> Update(int id,[FromBody]CustomerUpsert request)
        {
            return _service.Update(id, request);
        }
    }
}