    using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.Branch;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class BranchService : BaseCRUDService< BranchRequest, BranchSearchRequest,Branch,BranchUpsert,BranchUpsert>
    {
        public BranchService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<BranchRequest> Get(BranchSearchRequest search)
        {
            var query = _context.Set<Branch>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search.BranchName))                   // search for string
            {
                query = query.Where(x => x.BranchName.StartsWith(search.BranchName));
            }

            if (search?.CityId.HasValue == true)
            {
                query = query.Where(e => e.CityId == search.CityId);
            }

            return _mapper.Map<List<BranchRequest>>(query.ToList());
        } 
    }
}