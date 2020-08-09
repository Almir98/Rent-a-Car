using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Interface
{
    public interface IRecommendService
    {
        List<Data.Model.Vehicle> RecommendVehicle(int vehicleId);
    }
}
