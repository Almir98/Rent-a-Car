using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Interface;
using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel, Tsearch> : Controller
    {
        protected readonly IService<TModel, Tsearch> _service;

        public BaseController(IService<TModel, Tsearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<TModel> Get([FromQuery]Tsearch search)
        {
            return _service.Get(search);
        }


        [HttpGet("{id}")]
        public TModel GetById(int id)
        {
            return _service.GetByID(id);
        }
    }
}