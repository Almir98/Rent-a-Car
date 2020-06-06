using AutoMapper;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Models;
using RentaCar.Data.Requests;
using RentaCar.Data.Requests.Booking;
using RentaCar.Data.Requests.Branch;
using RentaCar.Data.Requests.City;
using RentaCar.Data.Requests.Comments;
using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Fuel_type;
using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Rating;
using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.Requests.VehicleModel;
using RentaCar.Data.Requests.VehicleType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rent_a_Car.WebAPI.Mappers
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<Database.City, CityRequest>().ReverseMap();
            CreateMap<Database.Branch, BranchRequest>().ReverseMap();
            CreateMap<BranchRequest, BranchSearchRequest>().ReverseMap();
            CreateMap<Database.Branch, BranchUpsert>().ReverseMap();

            CreateMap<Database.City, CityUpsert>().ReverseMap();
            CreateMap<Database.City, CitySearchRequest>().ReverseMap();

            CreateMap<Database.Customer, CustomerUpsert>().ReverseMap();
            CreateMap<CustomerRequest,Database.Customer>().ReverseMap();

            CreateMap<Database.Vehicle, VehicleUpsert>().ReverseMap();
            CreateMap<VehicleRequest, Database.Vehicle>().ReverseMap();

            CreateMap<Database.Booking, BookingUpsert>().ReverseMap();
            CreateMap<BookingRequest, Database.Booking>().ReverseMap();


            CreateMap<Comment, CommentUpsert>().ReverseMap();
            CreateMap<Database.Comment, MComment>();


            CreateMap<Database.Rating, RatingUpsert>().ReverseMap();
            CreateMap<Database.Rating, RatingRequest>().ReverseMap();

            CreateMap<FuelTypeRequest, Database.FuelType>().ReverseMap();

            CreateMap<VehicleTypeRequest, Database.VehicleType>().ReverseMap();

            CreateMap<ManufacturerRequest, Database.Manufacturer>().ReverseMap();

            CreateMap<VehicleModelRequest, Database.VehicleModel>().ReverseMap();


        }
    }
}
