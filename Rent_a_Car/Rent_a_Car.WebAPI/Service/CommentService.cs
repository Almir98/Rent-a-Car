using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentaCar.Data.Requests.Comments;
using RentACar.WebAPI.Database;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.WebAPI.Service
{
    public class CommentService : BaseCRUDService<Data.Model.Comment, CommentSearchRequest, Comment, CommentUpsert, CommentUpsert>
    {
        public CommentService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Data.Model.Comment> Get(CommentSearchRequest search)
        {
            var query = _context.Comment.Include(e=>e.Customer)
                .Include(e=>e.Vehicle)
                .Include(e=>e.Vehicle.VehicleModel)
                .Include(e=>e.Vehicle.VehicleModel.Manufacturer)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName.StartsWith(search.ManufacturerName));
            }
            query = query.OrderBy(x => x.DateOfComment);

            return _mapper.Map<List<Data.Model.Comment>>(query.ToList());
        }

        public override Data.Model.Comment GetByID(int id)
        {
            var comment = _context.Comment.Where(e => e.CommentId == id)
                .Include(e => e.Customer)
                .Include(e => e.Vehicle)
                .Include(e => e.Vehicle.VehicleModel)
                .Include(e => e.Vehicle.VehicleModel.Manufacturer)
                .FirstOrDefault();

            return _mapper.Map<Data.Model.Comment>(comment);
        }

    }
}
