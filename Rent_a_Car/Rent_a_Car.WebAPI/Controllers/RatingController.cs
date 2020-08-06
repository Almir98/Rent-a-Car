using Data.Model;
using RentaCar.Data.Requests.Rating;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class RatingController : BaseCRUDController<Data.Model.Rating, RatingSearchRequest, RatingUpsert, RatingUpsert>
    {
        public RatingController(ICRUDService<Rating, RatingSearchRequest, RatingUpsert, RatingUpsert> service) : base(service)
        {
        }
    }
}