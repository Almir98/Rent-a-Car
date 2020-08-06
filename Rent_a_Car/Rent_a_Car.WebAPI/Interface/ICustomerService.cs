using RentaCar.Data.Requests.Customer;
using System.Collections.Generic;

namespace RentACar.WebAPI.Interface
{
    public interface ICustomerService
    {
        List<Data.Model.Customer> Get(CustomerSearchRequest request);
        Data.Model.Customer GetById(int id);
        Data.Model.Customer Insert(CustomerUpsert request);
        Data.Model.Customer Update(int id, CustomerUpsert request);


        Data.Model.Customer Authenticate(CustomerLoginRequest request);
    }
}
