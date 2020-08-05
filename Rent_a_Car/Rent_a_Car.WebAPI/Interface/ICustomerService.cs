using RentaCar.Data.Requests.Customer;
using RentACar.WebAPI.Database;
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
        

        Data.Model.Customer Authenticate(CustomerLoginRequest request);
    }
}
