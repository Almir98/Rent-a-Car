using AutoMapper;
using RentaCar.Data.Requests.Booking;
using RentaCar.Data.Requests.Branch;
using RentaCar.Data.Requests.City;
using RentaCar.Data.Requests.Comments;
using RentaCar.Data.Requests.Customer;
using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Rating;
using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.Requests.VehicleModel;
using RentaCar.Data.Requests.VehicleType;
using RentACar.WebAPI.Database;

namespace Rent_a_Car.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<RentACar.WebAPI.Database.City, CityRequest>().ReverseMap();                    // City
            CreateMap<RentACar.WebAPI.Database.City, CityUpsert>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.City, CitySearchRequest>().ReverseMap();

            CreateMap<RentACar.WebAPI.Database.Branch, BranchRequest>().ReverseMap();                // Branch
            CreateMap<BranchRequest, BranchSearchRequest>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Branch, BranchUpsert>().ReverseMap();

            CreateMap<CustomerRequest, RentACar.WebAPI.Database.Customer>().ReverseMap();            //Customer
            CreateMap<CustomerRequest, CityRequest>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Customer, CustomerUpsert>().ReverseMap();


            CreateMap<VehicleRequest, RentACar.WebAPI.Database.Vehicle>().ReverseMap();              // Vehicle
            CreateMap<VehicleRequest, VehicleUpsert>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Vehicle, VehicleUpsert>().ReverseMap();

            CreateMap<VehicleRequest, RentACar.WebAPI.Database.Vehicle>().ReverseMap();

            CreateMap<RentACar.WebAPI.Database.Booking, BookingUpsert>().ReverseMap();               // Booking
            CreateMap<BookingRequest, RentACar.WebAPI.Database.Booking>().ReverseMap();
            CreateMap<BookingRequest, RentACar.WebAPI.Database.Customer>().ReverseMap();


            CreateMap<ManufacturerUpsert, RentACar.WebAPI.Database.Manufacturer>().ReverseMap();

            CreateMap<ManufacturerRequest, Manufacturer>().ReverseMap();
            CreateMap<VehicleModelRequest, RentACar.WebAPI.Database.VehicleModel>().ReverseMap();
            CreateMap<VehicleModelRequest, VehicleRequest>().ReverseMap();


            CreateMap<CommentRequest, VehicleRequest>().ReverseMap();
            CreateMap<CommentRequest, VehicleModelRequest>().ReverseMap();
            CreateMap<CommentRequest, ManufacturerRequest>().ReverseMap();


            CreateMap<CommentRequest, RentACar.WebAPI.Database.Vehicle>().ReverseMap();             // Comment
            CreateMap<CommentRequest, VehicleRequest>().ReverseMap();
            CreateMap<CommentRequest, RentACar.WebAPI.Database.VehicleModel>().ReverseMap();
            CreateMap<CommentRequest, Manufacturer>().ReverseMap();
            CreateMap<CommentRequest, RentACar.WebAPI.Database.Customer>().ReverseMap();

            CreateMap<Comment, CommentUpsert>().ReverseMap();
            CreateMap<CommentRequest, RentACar.WebAPI.Database.Comment>().ReverseMap();


            CreateMap<VehicleTypeRequest, RentACar.WebAPI.Database.VehicleType>().ReverseMap();
            CreateMap<VehicleModelRequest, RentACar.WebAPI.Database.VehicleModel>().ReverseMap();
            CreateMap<VehicleModelUpsert, RentACar.WebAPI.Database.VehicleModel>().ReverseMap();


            CreateMap<RatingRequest, RentACar.WebAPI.Database.Customer>().ReverseMap();                 //Rating
            CreateMap<RentACar.WebAPI.Database.Rating, RatingRequest>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Rating, RatingUpsert>().ReverseMap();

            CreateMap<RatingRequest, RentACar.WebAPI.Database.Vehicle>().ReverseMap();
            CreateMap<RatingRequest, RentACar.WebAPI.Database.VehicleModel>().ReverseMap();
            CreateMap<RatingRequest, RentACar.WebAPI.Database.Manufacturer>().ReverseMap();

            CreateMap<RatingRequest, RentACar.WebAPI.Database.Vehicle>().ReverseMap();
            CreateMap<RatingRequest, RentACar.WebAPI.Database.Manufacturer>().ReverseMap();
            CreateMap<RatingRequest, RentACar.WebAPI.Database.VehicleModel>().ReverseMap();


            CreateMap<CustomerLoginRequest, Data.Model.Customer>().ReverseMap();
            CreateMap<CustomerSearchRequest, Data.Model.Customer>().ReverseMap();
            CreateMap<CustomerSearchRequest, Customer>().ReverseMap();

            // novi

            CreateMap<RentACar.WebAPI.Database.Customer, Data.Model.Customer>().ReverseMap();

            CreateMap<RentACar.WebAPI.Database.CustomerType, Data.Model.CustomerType>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.City, Data.Model.City>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Booking, Data.Model.Booking>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Rating, Data.Model.Rating>().ReverseMap();

            CreateMap<RentACar.WebAPI.Database.Branch, Data.Model.Branch>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Comment, Data.Model.Comment>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.FuelType, Data.Model.FuelType>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Manufacturer, Data.Model.Manufacturer>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.Vehicle, Data.Model.Vehicle>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.VehicleModel, Data.Model.VehicleModel>().ReverseMap();
            CreateMap<RentACar.WebAPI.Database.VehicleType, Data.Model.VehicleType>().ReverseMap();

        }
    }
}
