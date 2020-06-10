using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Models;
using RentaCar.Data.Requests.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class CommentService : BaseCRUDService<RentaCar.Data.Models.MComment, CommentSearchRequest, Comment, CommentUpsert, CommentUpsert>
    {
        public CommentService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MComment> Get(CommentSearchRequest search)
        {
            var query = _context.Comment.Include(x=>x.Customer)
                .Include(x=>x.Vehicle)
                .Include(x=>x.Vehicle.VehicleModel)
                .Include(x=>x.Vehicle.VehicleModel.Manufacturer)
                .AsQueryable();

            if(!string.IsNullOrEmpty(search.CustomerFirstName))
            {
                query = query.Where(x => x.Customer.FirstName == search.CustomerFirstName);
            }
            
            if(!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName == search.ManufacturerName);
            }

            var lista = query.ToList();

            return _mapper.Map<List<MComment>>(lista);
        }

    }
}
