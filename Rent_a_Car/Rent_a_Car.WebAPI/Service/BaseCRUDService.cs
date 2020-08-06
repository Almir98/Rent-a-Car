using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Interface;
using System;

namespace RentACar.WebAPI.Service
{
    public class BaseCRUDService<TModel, Tsearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, Tsearch, TDatabase>, ICRUDService<TModel, Tsearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            if (entity == null)
                throw new ArgumentNullException();
            else
            {
                _context.Set<TDatabase>().Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
