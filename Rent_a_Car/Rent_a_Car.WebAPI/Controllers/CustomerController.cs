using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Customer;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class CustomerController : BaseCRUDController<CustomerRequest, CustomerSearchRequest, CustomerUpsert, CustomerUpsert>
    {
        public CustomerController(ICRUDService<CustomerRequest, CustomerSearchRequest, CustomerUpsert, CustomerUpsert> service) : base(service)
        {
        }
    }
}