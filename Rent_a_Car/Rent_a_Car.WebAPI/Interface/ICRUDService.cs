using Rent_a_Car.WebAPI.Interface;

namespace RentACar.WebAPI.Interface
{
    public interface ICRUDService<TModel, Tsearch, TInsert, TUpdate> : IService<TModel, Tsearch>
    {
        TModel Insert(TInsert request);

        TModel Update(int id, TUpdate request);
        void Delete(int id);
    }
}
