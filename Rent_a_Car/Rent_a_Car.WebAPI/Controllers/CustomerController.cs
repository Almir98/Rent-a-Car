using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Customer;
using RentACar.WebAPI.Interface;
using System.Collections.Generic;

namespace RentACar.WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        //[Authorize(Roles ="Administrator")]
        [HttpGet]
        public ActionResult<List<Data.Model.Customer>> Get([FromQuery]CustomerSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Data.Model.Customer> GetById(int id)
        {
            return _service.GetById(id);
        }

        //[Authorize(Roles = "Administrator")]      // ispravit !!!!
        [HttpPost]
        public ActionResult<Data.Model.Customer> Insert(CustomerUpsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public ActionResult<Data.Model.Customer> Update(int id, [FromBody]CustomerUpsert request)
        {
            return _service.Update(id, request);
        }
    }
}