using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Requests.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Interface
{
    public interface ICustomerService
    {
        List<CustomerRequest> Get(CustomerSearchRequest request);
        CustomerRequest GetById(int id);
        CustomerRequest Insert(CustomerUpsert request);
        CustomerRequest Update(int id,CustomerUpsert request);
        

        Customer Authenticate(CustomerLoginRequest request);
    }
}
