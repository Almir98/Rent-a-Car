using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_a_Car.WebAPI.Controllers;
using Rent_a_Car.WebAPI.Interface;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCRUDController<TModel, Tsearch,TInsert,TUpdate> : BaseController<TModel, Tsearch>
    {
        private readonly ICRUDService<TModel, Tsearch, TInsert, TUpdate> _service=null;

        public BaseCRUDController(ICRUDService<TModel, Tsearch,TInsert,TUpdate> service) : base(service)
        {
            _service = service;
        }


        [HttpPost]
        public TModel Insert(TInsert request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public TModel Update(int id,TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}