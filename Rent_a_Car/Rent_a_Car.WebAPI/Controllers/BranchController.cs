using Data.Model;
using RentaCar.Data.Requests.Branch;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class BranchController : BaseCRUDController<Data.Model.Branch, BranchSearchRequest, BranchUpsert, BranchUpsert>
    {
        public BranchController(ICRUDService<Branch, BranchSearchRequest, BranchUpsert, BranchUpsert> service) : base(service)
        {
        }
    }
}