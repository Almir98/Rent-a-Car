using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class CustomerService : BaseCRUDService<CustomerRequest, CustomerSearchRequest,Customer,CustomerUpsert,CustomerUpsert>
    {
        public CustomerService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<CustomerRequest> Get(CustomerSearchRequest search)
        {
            var query = _context.Set<Customer>().Include(x=>x.City).AsQueryable();

            if(!string.IsNullOrWhiteSpace(search.FirstName) || !string.IsNullOrWhiteSpace(search.LastName))
            {
                query = query.Where(x => x.LastName == search.LastName || x.FirstName == search.FirstName);
            }

            if(!string.IsNullOrWhiteSpace(search.CityName))
            {
                query = query.Where(x => x.City.CityName == search.CityName);
            }
            query = query.OrderBy(x => x.City.CityName);
            return _mapper.Map<List<CustomerRequest>>(query.ToList());
        }
    }
}
