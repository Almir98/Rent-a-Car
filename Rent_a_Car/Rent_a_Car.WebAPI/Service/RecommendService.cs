using AutoMapper;
using Data.Model;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class RecommendService : IRecommendService
    {
        protected readonly RentaCarContext _context;
        protected readonly IMapper _mapper;

        public RecommendService(RentaCarContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Data.Model.Vehicle> RecommendVehicle(int vehicleId)
        {
            //LoadSimilar(vehicleId);
            throw new NotImplementedException();

        }

        //private void LoadSimilar(int vehicleId)
        //{
        //        // mozda moze i oni koji su status TRUE !! KASNIJE TO 

        //    List<Database.Vehicle> allVehicles = _context.Vehicle.Where(e => e.VehicleId != vehicleId).ToList();

        //    List<Database.Rating> 

            
            
            
        //    throw new NotImplementedException();
        //}























    }
}
