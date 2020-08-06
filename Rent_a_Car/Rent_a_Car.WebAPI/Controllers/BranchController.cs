using RentaCar.Data.Requests.Branch;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class BranchController : BaseCRUDController<BranchRequest, BranchSearchRequest, BranchUpsert, BranchUpsert>
    {
        public BranchController(ICRUDService<BranchRequest, BranchSearchRequest, BranchUpsert, BranchUpsert> service) : base(service)
        {
        }
    }
}