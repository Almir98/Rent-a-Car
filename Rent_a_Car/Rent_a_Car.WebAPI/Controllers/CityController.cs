using Data.Model;
using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.City;

namespace Rent_a_Car.WebAPI.Controllers
{
    public class CityController : BaseController<Data.Model.City, CitySearchRequest>
    {
        public CityController(IService<City, CitySearchRequest> service) : base(service)
        {
        }
    }
}