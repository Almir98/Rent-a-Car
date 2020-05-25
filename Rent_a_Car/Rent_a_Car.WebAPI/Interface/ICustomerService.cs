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
        CustomerRequest Insert(CustomerUpsert request);
        CustomerRequest Update(int id,CustomerUpsert request);
    }
}
