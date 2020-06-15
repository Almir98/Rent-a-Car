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
    public class CommentService : BaseCRUDService<CommentRequest, CommentSearchRequest, Comment, CommentUpsert, CommentUpsert>
    {
        public CommentService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<CommentRequest> Get(CommentSearchRequest search)
        {
            var query = _context.Comment.Include("Customer")
                .Include("Vehicle")
                .Include("Vehicle.VehicleModel")
                .Include("Vehicle.VehicleModel.Manufacturer")
                .AsQueryable();

            if(!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            query = query.OrderBy(x => x.DateOfComment);

            return _mapper.Map<List<CommentRequest>>(query.ToList());
        }
    }
}
