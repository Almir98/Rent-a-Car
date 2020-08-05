using Rent_a_Car.WebAPI.Interface;
using RentaCar.Data.Requests.City;

namespace Rent_a_Car.WebAPI.Controllers
{
    public class CityController : BaseController<CityRequest, CitySearchRequest>
    {
        public CityController(IService<CityRequest, CitySearchRequest> service) : base(service)
        {
        }
    }
}