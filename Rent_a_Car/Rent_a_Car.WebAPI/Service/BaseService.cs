using AutoMapper;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Rent_a_Car.WebAPI.Service
{
    public class BaseService<TModel, Tsearch,TDatabase> : IService<TModel, Tsearch> where TDatabase: class
    {
        private readonly RentaCarContext _context;
        private readonly IMapper _mapper;

        public BaseService(RentaCarContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<TModel> Get(Tsearch search)
        {
            return _mapper.Map<List<TModel>>(_context.Set<TDatabase>().ToList());
        } 

        public TModel GetByID(int id)
        {
            return _mapper.Map<TModel>(_context.Set<TDatabase>().Find(id));
        }
    }
}
