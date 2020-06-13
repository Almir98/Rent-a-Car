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
            CreateMap<Database.City, CityRequest>().ReverseMap();
            CreateMap<Database.Branch, BranchRequest>().ReverseMap();
            CreateMap<BranchRequest, BranchSearchRequest>().ReverseMap();
            CreateMap<Database.Branch, BranchUpsert>().ReverseMap();

            CreateMap<Database.City, CityUpsert>().ReverseMap();
            CreateMap<Database.City, CitySearchRequest>().ReverseMap();

            CreateMap<CustomerRequest, Database.Customer>().ReverseMap();           //vicemo
            CreateMap<CustomerRequest, CityRequest>().ReverseMap();           

            CreateMap<Database.Customer, CustomerUpsert>().ReverseMap();
            CreateMap<RentaCar.Data.Models.Customer,Database.Customer>().ReverseMap();

            CreateMap<VehicleRequest, VehicleUpsert>().ReverseMap();
            CreateMap<VehicleRequest, Database.Vehicle>().ReverseMap();

            CreateMap<Database.Booking, BookingUpsert>().ReverseMap();      // Booking
            CreateMap<BookingRequest, Database.Booking>().ReverseMap();
            CreateMap<BookingRequest, Database.Vehicle>().ReverseMap();
            CreateMap<BookingRequest, Database.Customer>().ReverseMap();

            CreateMap<Comment, CommentUpsert>().ReverseMap();
            
            CreateMap<Comment,MComment>();
            CreateMap<MComment, Comment>();
            

            CreateMap<Database.Rating, RatingUpsert>().ReverseMap();
            CreateMap<Database.Rating, RatingRequest>().ReverseMap();

            CreateMap<FuelTypeRequest, Database.FuelType>().ReverseMap();

            CreateMap<VehicleTypeRequest, Database.VehicleType>().ReverseMap();


            // upitno je
            CreateMap<ManufacturerRequest, Database.Manufacturer>().ReverseMap();
            CreateMap<VehicleModelRequest, Database.VehicleModel>().ReverseMap();

        }
    }
}
