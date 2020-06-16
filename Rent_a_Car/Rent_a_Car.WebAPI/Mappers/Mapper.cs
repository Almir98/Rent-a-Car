using AutoMapper;
using Rent_a_Car.WebAPI.Database;
using RentaCar.Data.Models;
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

namespace Rent_a_Car.WebAPI.Mappers
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<Database.City, CityRequest>().ReverseMap();                    // City
            CreateMap<Database.City, CityUpsert>().ReverseMap();
            CreateMap<Database.City, CitySearchRequest>().ReverseMap();

            CreateMap<Database.Branch, BranchRequest>().ReverseMap();                // Branch
            CreateMap<BranchRequest, BranchSearchRequest>().ReverseMap();
            CreateMap<Database.Branch, BranchUpsert>().ReverseMap();

            CreateMap<CustomerRequest, Database.Customer>().ReverseMap();            //Customer
            CreateMap<CustomerRequest, CityRequest>().ReverseMap();   
            CreateMap<Database.Customer, CustomerUpsert>().ReverseMap();


            CreateMap<VehicleRequest, Database.Vehicle>().ReverseMap();              // Vehicle
            CreateMap<VehicleRequest, VehicleUpsert>().ReverseMap();
            CreateMap<Database.Vehicle, VehicleUpsert>().ReverseMap();

            CreateMap<VehicleRequest, Database.Vehicle>().ReverseMap();

            CreateMap<Database.Booking, BookingUpsert>().ReverseMap();               // Booking
            CreateMap<BookingRequest, Database.Booking>().ReverseMap();
            CreateMap<BookingRequest, Database.Customer>().ReverseMap();


            CreateMap<ManufacturerRequest, Manufacturer>().ReverseMap();
            CreateMap<VehicleModelRequest, Database.VehicleModel>().ReverseMap();
            CreateMap<VehicleModelRequest, VehicleRequest>().ReverseMap();


            CreateMap<CommentRequest, VehicleRequest>().ReverseMap();
            CreateMap<CommentRequest, VehicleModelRequest>().ReverseMap();
            CreateMap<CommentRequest, ManufacturerRequest>().ReverseMap();


            CreateMap<CommentRequest, Database.Vehicle>().ReverseMap();             // Comment
            CreateMap<CommentRequest, VehicleRequest>().ReverseMap();
            CreateMap<CommentRequest, Database.VehicleModel>().ReverseMap();
            CreateMap<CommentRequest, Manufacturer>().ReverseMap();
            CreateMap<CommentRequest, Database.Customer>().ReverseMap();

            CreateMap<Comment, CommentUpsert>().ReverseMap();
            CreateMap<CommentRequest, Database.Comment>().ReverseMap();

            
            CreateMap<FuelTypeRequest, Database.FuelType>().ReverseMap();
            CreateMap<VehicleTypeRequest, Database.VehicleType>().ReverseMap();
            CreateMap<VehicleModelRequest, Database.VehicleModel>().ReverseMap();

            CreateMap<RatingRequest, Database.Customer>().ReverseMap();                 //Rating
            CreateMap<Database.Rating, RatingRequest>().ReverseMap();
            CreateMap<Database.Rating, RatingUpsert>().ReverseMap();

            CreateMap<RatingRequest, Database.Vehicle>().ReverseMap();
            CreateMap<RatingRequest, Database.VehicleModel>().ReverseMap();
            CreateMap<RatingRequest, Database.Manufacturer>().ReverseMap();

            CreateMap<RatingRequest, Database.Vehicle>().ReverseMap();
            CreateMap<RatingRequest, Database.Manufacturer>().ReverseMap();
            CreateMap<RatingRequest, Database.VehicleModel>().ReverseMap();
        }
    }
}
