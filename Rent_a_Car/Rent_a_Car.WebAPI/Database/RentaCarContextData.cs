using Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Database
{
    public partial class RentaCarContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            // CUSTOMER TYPE

            modelBuilder.Entity<CustomerType>().HasData(new CustomerType()
            {
                CustomerTypeId=1,
                Type="Administator"
            });

            modelBuilder.Entity<CustomerType>().HasData(new CustomerType()
            {
                CustomerTypeId = 2,
                Type = "Korisnik"
            });

            ////CITY

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 1,
                CityName = "Sarajevo",
                PostCode = "71000"
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 2,
                CityName = "Mostar",
                PostCode = "88000"
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 3,
                CityName = "Travnik",
                PostCode = "72270"
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 4,
                CityName = "Bugojno",
                PostCode = "70230"
            });


            // CUSTOMER -> Administrator

            Customer c = new Customer
            {
                CustomerId = 1,
                FirstName = "Almir",
                LastName = "Tihak",
                Phone = "0611111",
                Email = "almir@fit.ba",
                Username = "desktop",
                CityId = 1,
                CustomerTypeId = 1
            };
            c.PasswordSalt = HashGenerator.GenerateSalt();
            c.PasswordHash = HashGenerator.GenerateHash(c.PasswordSalt, "test");
            modelBuilder.Entity<Customer>().HasData(c);

            // CUSTOMER -> Mobile user

            Customer a = new Customer
            {
                CustomerId = 2,
                FirstName = "Tester",
                LastName = "Tester",
                Phone = "0622222",
                Email = "test@fit.ba",
                Username = "mobile",
                CityId = 2,
                CustomerTypeId = 2
            };
            a.PasswordSalt = HashGenerator.GenerateSalt();
            a.PasswordHash = HashGenerator.GenerateHash(a.PasswordSalt, "test");
            modelBuilder.Entity<Customer>().HasData(a);

            //BRANCH

            modelBuilder.Entity<Branch>().HasData(new Branch()
            {
                BranchId = 1,
                BranchName = "Kramar",
                PhoneNumber = "255 251",
                Adress = "Nova Otoka 4",
                OpenTime = "08:00",
                CloseTime = "17:00",
                Description = "Dođite i uvjerite se u nas kvalitet.",
                CityId = 1
            });

            modelBuilder.Entity<Branch>().HasData(new Branch()
            {
                BranchId = 2,
                BranchName = "Buba salon",
                PhoneNumber = "255 252",
                Adress = "Carinska bb",
                OpenTime = "08:00",
                CloseTime = "17:00",
                Description = "Dođite i uvjerite se u nas kvalitet.",
                CityId = 2
            });

            modelBuilder.Entity<Branch>().HasData(new Branch()
            {
                BranchId = 3,
                BranchName = "Zoom",
                PhoneNumber = "255 253",
                Adress = "Titova bb",
                OpenTime = "08:00",
                CloseTime = "17:00",
                Description = "Dođite i uvjerite se u nas kvalitet.",
                CityId = 3
            });

            modelBuilder.Entity<Branch>().HasData(new Branch()
            {
                BranchId = 4,
                BranchName = "Lijanović salon",
                PhoneNumber = "255 254",
                Adress = "Nugle 5",
                OpenTime = "08:00",
                CloseTime = "17:00",
                Description = "Dođite i uvjerite se u nas kvalitet.",
                CityId = 4
            });

            //FUEL TYPE

            modelBuilder.Entity<FuelType>().HasData(new FuelType()
            {
                FuelTypeId = 1,
                FuelName = "Diesel"
            });

            modelBuilder.Entity<FuelType>().HasData(new FuelType()
            {
                FuelTypeId = 2,
                FuelName = "Benzin"
            });

            modelBuilder.Entity<FuelType>().HasData(new FuelType()
            {
                FuelTypeId = 3,
                FuelName = "Gas"
            });

            modelBuilder.Entity<FuelType>().HasData(new FuelType()
            {
                FuelTypeId = 4,
                FuelName = "LPG"
            });

            modelBuilder.Entity<FuelType>().HasData(new FuelType()
            {
                FuelTypeId = 5,
                FuelName = "Hybrid"
            });

            modelBuilder.Entity<FuelType>().HasData(new FuelType()
            {
                FuelTypeId = 6,
                FuelName = "Elektro"
            });

            // VEHICLE TYPE

            modelBuilder.Entity<VehicleType>().HasData(new VehicleType()
            {
                VehcileTypeId = 1,
                TypeName = "Limousine"
            });

            modelBuilder.Entity<VehicleType>().HasData(new VehicleType()
            {
                VehcileTypeId = 2,
                TypeName = "Caravan"
            });

            modelBuilder.Entity<VehicleType>().HasData(new VehicleType()
            {
                VehcileTypeId = 3,
                TypeName = "SUV"
            });

            modelBuilder.Entity<VehicleType>().HasData(new VehicleType()
            {
                VehcileTypeId = 4,
                TypeName = "Sports/Coupe"
            });

            modelBuilder.Entity<VehicleType>().HasData(new VehicleType()
            {
                VehcileTypeId = 5,
                TypeName = "Off road"
            });

            // MANUFACTURER

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 1,
                ManufacturerName = "Audi"
            });

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 2,
                ManufacturerName = "BMW"
            });

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 3,
                ManufacturerName = "Mercedes-Benz"
            });

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 4,
                ManufacturerName = "Volkswagen"
            });

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 5,
                ManufacturerName = "Porsche"
            });

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 6,
                ManufacturerName = "Citroen"
            });

            modelBuilder.Entity<Manufacturer>().HasData(new Manufacturer()
            {
                ManufacturerId = 7,
                ManufacturerName = "Škoda"
            });

            //VEHICLEMODEL

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 1,
                ModelName = "A6",
                ManufacturerId = 1
            });

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 2,
                ModelName = "A7",
                ManufacturerId = 1
            });

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 3,
                ModelName = "530d",
                ManufacturerId = 2
            });

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 4,
                ModelName = "C220",
                ManufacturerId = 3
            });

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 5,
                ModelName = "Passat",
                ManufacturerId = 4
            });

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 6,
                ModelName = "Carrera 4S",
                ManufacturerId = 5
            });

            modelBuilder.Entity<VehicleModel>().HasData(new VehicleModel()
            {
                ModelId = 7,
                ModelName = "C5",
                ManufacturerId = 6
            });


            // VEHICLES

            // Audi A6 
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 1,
                RegistrationNumber = "A11-A-111",
                Image = File.ReadAllBytes("img/audia6.jpg"),
                VehicleNumber = 1,
                DailyPrice = 100,
                Description = "Audi A6 3.0 TDI Quattro. Vrhunski auto, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2015, 6, 6),
                Mileage = "170500",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = true,
                BranchId = 1,
                FuelTypeId = 1,
                VehicleTypeId = 1,
                VehicleModelId = 1
            });

            // Audi A7 
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 2,
                RegistrationNumber = "B22-B-222",
                Image = File.ReadAllBytes("img/audia7.jpg"),
                VehicleNumber = 2,
                DailyPrice = 120,
                Description = "Audi A7 3.0 TFSI Quattro. Vrhunski auto, 300 KS, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2018, 6, 6),
                Mileage = "100000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = true,
                BranchId = 2,
                FuelTypeId = 2,
                VehicleTypeId = 4,
                VehicleModelId = 2
            });

            // BMW 530d
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 3,
                RegistrationNumber = "C33-C-333",
                Image = File.ReadAllBytes("img/bmw.jpg"),
                VehicleNumber = 3,
                DailyPrice = 90,
                Description = "BMW 530d 258 KS. Vrhunski auto, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2012, 1, 1),
                Mileage = "100700",
                Transmission = "Manuleni",
                NumberOfSeats = 5,
                Status = true,
                BranchId = 3,
                FuelTypeId = 1,
                VehicleTypeId = 1,
                VehicleModelId = 3
            });

            // Mercedes c220
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 4,
                RegistrationNumber = "D44-D-444",
                Image = File.ReadAllBytes("img/mercedes.jpg"),
                VehicleNumber = 4,
                DailyPrice = 100,
                Description = "Mercedes-Benz C220 CDI 170 KS. Vrhunski auto, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2017, 2, 2),
                Mileage = "170000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = true,
                BranchId = 4,
                FuelTypeId = 1,
                VehicleTypeId = 2,
                VehicleModelId = 4
            });

            // Passat 8
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 5,
                RegistrationNumber = "E55-E-555",
                Image = File.ReadAllBytes("img/passat.jfif"),
                VehicleNumber = 5,
                DailyPrice = 100,
                Description = "Volkswagen Passat 8 170 KS. Vrhunski auto, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2019, 3, 3),
                Mileage = "10000",
                Transmission = "Manuelni",
                NumberOfSeats = 4,
                Status = true,
                BranchId = 4,
                FuelTypeId = 1,
                VehicleTypeId = 3,
                VehicleModelId = 5
            });

            // Porsche 4S
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 6,
                RegistrationNumber = "F66-F-666",
                Image = File.ReadAllBytes("img/porsche.jpg"),
                VehicleNumber = 6,
                DailyPrice = 150,
                Description = "Porsche Carrera 4S 350 KS. Vrhunski auto, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2017, 4, 4),
                Mileage = "20000",
                Transmission = "Automatik",
                NumberOfSeats = 2,
                Status = true,
                BranchId = 1,
                FuelTypeId = 2,
                VehicleTypeId = 4,
                VehicleModelId = 6
            });

            // Citroen C5
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle()
            {
                VehicleId = 7,
                RegistrationNumber = "G77-G-777",
                Image = File.ReadAllBytes("img/citroen.jpg"),
                VehicleNumber = 7,
                DailyPrice = 90,
                Description = "Citroen C5 150 KS. Vrhunski auto, super ocuvan. Spreman da odgovori na sve vase potrebe.",
                ManufacturerDate = new DateTime(2008, 5, 5),
                Mileage = "200000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = true,
                BranchId = 2,
                FuelTypeId = 1,
                VehicleTypeId = 5,
                VehicleModelId = 7
            });

            // BOOKING

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 1,
                StartDate = new DateTime(2020, 08, 14),
                EndDate = new DateTime(2020, 08, 16),
                CustomerId = 2,
                VehicleId = 1,
                RatingStatus = true,
                CommentStatus = true
            });

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 2,
                StartDate = new DateTime(2020, 08, 01),
                EndDate = new DateTime(2020, 08, 05),
                CustomerId = 2,
                VehicleId = 2,
                RatingStatus = true,
                CommentStatus = true
            });

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 3,
                StartDate = new DateTime(2020, 08, 02),
                EndDate = new DateTime(2020, 08, 10),
                CustomerId = 2,
                VehicleId = 3,
                RatingStatus = true,
                CommentStatus = true
            });

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 4,
                StartDate = new DateTime(2020, 08, 03),
                EndDate = new DateTime(2020, 08, 10),
                CustomerId = 2,
                VehicleId = 4,
                RatingStatus = true,
                CommentStatus = true
            });

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 5,
                StartDate = new DateTime(2020, 08, 05),
                EndDate = new DateTime(2020, 08, 07),
                CustomerId = 2,
                VehicleId = 5,
                RatingStatus = true,
                CommentStatus = true
            });

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 6,
                StartDate = new DateTime(2020, 08, 07),
                EndDate = new DateTime(2020, 08, 10),
                CustomerId = 2,
                VehicleId = 6,
                RatingStatus = true,
                CommentStatus = true
            });

            modelBuilder.Entity<Booking>().HasData(new Booking()
            {
                BookingId = 7,
                StartDate = new DateTime(2020, 08, 11),
                EndDate = new DateTime(2020, 08, 13),
                CustomerId = 2,
                VehicleId = 7,
                RatingStatus = true,
                CommentStatus = true
            });

            // COMMENT

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 1,
                Description = "Audi A6 je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 10),
                CustomerId = 2,
                VehicleId = 1
            });

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 2,
                Description = "Audi A7 je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 11),
                CustomerId = 2,
                VehicleId = 2
            });

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 3,
                Description = "BMW 530d je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 12),
                CustomerId = 2,
                VehicleId = 3
            });

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 4,
                Description = "Mercede-Benz C220 CDI je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 12),
                CustomerId = 2,
                VehicleId = 4
            });

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 5,
                Description = "Volkswagen Passat 8 je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 13),
                CustomerId = 2,
                VehicleId = 5
            });

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 6,
                Description = "Porsche Carrera 4S je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 14),
                CustomerId = 2,
                VehicleId = 6
            });

            modelBuilder.Entity<Comment>().HasData(new Comment()
            {
                CommentId = 7,
                Description = "Citroen C5 HDI je vrhunski auto. Preporučujem ga, sve pohvale.",
                DateOfComment = new DateTime(2020, 08, 15),
                CustomerId = 2,
                VehicleId = 7
            });


            // RATING                                                  

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 1,
                RatingValue = 9,
                CustomerId = 2,
                VehicleId = 1,
                RatingDate=new DateTime(2020,08,10)
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 2,
                RatingValue = 10,
                CustomerId = 2,
                VehicleId = 2,
                RatingDate = new DateTime(2020, 08, 11)
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 3,
                RatingValue = 7,
                CustomerId = 2,
                VehicleId = 3,
                RatingDate = new DateTime(2020, 08, 12)
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 4,
                RatingValue = 5,
                CustomerId = 2,
                VehicleId = 4,
                RatingDate = new DateTime(2020, 08, 13)
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 5,
                RatingValue = 6,
                CustomerId = 2,
                VehicleId = 5,
                RatingDate = new DateTime(2020, 08, 14)
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 6,
                RatingValue = 7,
                CustomerId = 2,
                VehicleId = 6,
                RatingDate = new DateTime(2020, 08, 15)
            });

            modelBuilder.Entity<Rating>().HasData(new Rating()
            {
                RatingId = 7,
                RatingValue = 4,
                CustomerId = 2,
                VehicleId = 5,
                RatingDate = new DateTime(2020, 08, 16)
            });
        }
    }
}
