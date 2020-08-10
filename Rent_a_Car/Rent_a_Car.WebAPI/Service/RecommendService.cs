using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

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

        Dictionary<int, List<Database.Rating>> vehicles = new Dictionary<int, List<Database.Rating>>();

        public List<Data.Model.Vehicle> RecommendVehicle(int vehicleId)
        {
            var tmp=LoadSimilar(vehicleId);
            return _mapper.Map<List<Data.Model.Vehicle>>(tmp);
        }

        private List<Database.Vehicle> LoadSimilar(int vehicleId)
        {
            LoadDifVehicles(vehicleId);
            List<Database.Rating> ratingsOfThis = _context.Rating.Where(e => e.VehicleId == vehicleId).OrderBy(e => e.CustomerId).ToList();

            List<Database.Rating> ratings1 = new List<Database.Rating>();
            List<Database.Rating> ratings2 = new List<Database.Rating>();
            List<Database.Vehicle> recommendedVehicles = new List<Database.Vehicle>();

            foreach (var item in vehicles)
            {
                foreach (Database.Rating rating in ratingsOfThis)
                {
                    if (item.Value.Where(x => x.CustomerId == rating.CustomerId).Count() > 0)
                    {
                        ratings1.Add(rating);
                        ratings2.Add(item.Value.Where(x => x.CustomerId == rating.CustomerId).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recommendedVehicles.Add(_context.Vehicle.Where(x => x.VehicleId == item.Key)
                        .Include(x=>x.VehicleModel)
                        .Include(x=>x.VehicleModel.Manufacturer)
                        .FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }
            return recommendedVehicles;
        }

        private double GetSimilarity(List<Database.Rating> ratings1, List<Database.Rating> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x = ratings1[i].RatingValue * ratings2[i].RatingValue;
                y1 = ratings1[i].RatingValue * ratings1[i].RatingValue;
                y2 = ratings2[i].RatingValue * ratings2[i].RatingValue;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }

        private void LoadDifVehicles(int vehicleId)
        {
            List<Database.Vehicle> allVehicles = _context.Vehicle.Where(e => e.VehicleId != vehicleId).ToList();
            List<Database.Rating> ratings = new List<Database.Rating>();
            foreach (var item in allVehicles)
            {
                ratings = _context.Rating.Where(e => e.VehicleId == item.VehicleId).OrderBy(e=>e.CustomerId).ToList();
                if (ratings.Count > 0)
                    vehicles.Add(item.VehicleId, ratings);
            }
        }
    }
}
