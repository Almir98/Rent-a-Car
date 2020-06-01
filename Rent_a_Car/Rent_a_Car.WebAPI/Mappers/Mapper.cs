using AutoMapper;
using Rent_a_Car.WebAPI.Database;
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
            CreateMap<City, CityRequest>().ReverseMap();
            CreateMap<Branch, BranchRequest>().ReverseMap();
            CreateMap<BranchRequest, BranchSearchRequest>().ReverseMap();
            CreateMap<Branch, BranchUpsert>().ReverseMap();

            CreateMap<City, CityUpsert>().ReverseMap();
            CreateMap<City, CitySearchRequest>().ReverseMap();

            CreateMap<Customer, CustomerUpsert>().ReverseMap();
            CreateMap<CustomerRequest, Customer>().ReverseMap();

            CreateMap<Vehicle, VehicleUpsert>().ReverseMap();
            CreateMap<VehicleRequest, Vehicle>().ReverseMap();

            CreateMap<Booking, BookingUpsert>().ReverseMap();
            CreateMap<BookingRequest, Booking>().ReverseMap();

            CreateMap<Comment, CommentUpsert>().ReverseMap();
            CreateMap<Comment, CommentRequest>().ReverseMap();

            CreateMap<Rating, RatingUpsert>().ReverseMap();
            CreateMap<Rating, RatingRequest>().ReverseMap();

            CreateMap<FuelTypeRequest, FuelType>().ReverseMap();

            CreateMap<VehicleTypeRequest, VehicleType>().ReverseMap();

            CreateMap<ManufacturerRequest, Manufacturer>().ReverseMap();

            CreateMap<VehicleModelRequest, VehicleModel>().ReverseMap();


        }
    }
}
