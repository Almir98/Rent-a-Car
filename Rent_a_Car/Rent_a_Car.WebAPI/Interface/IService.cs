using System.Collections.Generic;

namespace Rent_a_Car.WebAPI.Interface
{
    public interface IService<TModel, Tsearch>
    {
        List<TModel> Get(Tsearch search);
        TModel GetByID(int id);
    }
}
