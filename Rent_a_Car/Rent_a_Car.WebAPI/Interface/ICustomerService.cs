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
        List<Data.Model.Customer> Get(CustomerSearchRequest request);
        Data.Model.Customer GetById(int id);
        Data.Model.Customer Insert(CustomerUpsert request);
        Data.Model.Customer Update(int id,CustomerUpsert request);
        

        Data.Model.Customer Authenticate(CustomerLoginRequest request);
    }
}
