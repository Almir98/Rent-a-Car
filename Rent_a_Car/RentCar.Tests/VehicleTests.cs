using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Mappers;
using RentaCar.Data.Requests.Vehicle;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Service;
using Xunit;

namespace RentCar.Tests
{
    public class VehicleTests
    {
        public VehicleService _vehicleService;
        public RentaCarContext _context = new RentaCarContext();
        public IMapper _mapper;

        public VehicleTests()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new Rent_a_Car.WebAPI.Mappers.Mapper());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            var options = new DbContextOptionsBuilder<RentaCarContext>()
                .UseInMemoryDatabase(databaseName: "RentCar").Options;

            _context = new RentaCarContext(options);
            _vehicleService = new VehicleService(_context, _mapper);
        }


        [Fact]
        public void Get_FilterByRegistrationNumber_ReturnOk()
        {
            //Arrange
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 1,
                RegistrationNumber = "A77-B-312",
                VehicleNumber = 1,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "190.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 1,
                FuelTypeId = 1,
                VehicleTypeId = 1,
                VehicleModelId = 1
            });
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 2,
                RegistrationNumber = "A22-E222",
                VehicleNumber = 2,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "195.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 2,
                FuelTypeId = 2,
                VehicleTypeId = 2,
                VehicleModelId = 2
            });
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 3,
                RegistrationNumber = "A22-E333",
                VehicleNumber = 3,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "280.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 3,
                FuelTypeId = 3,
                VehicleTypeId = 3,
                VehicleModelId = 3
            });
            _context.SaveChanges();

            VehicleSearchRequest request = new VehicleSearchRequest
            {
                RegistrationNumber = "A22-E333"
            };

            //Act 
            var list = _vehicleService.Get(request);

            //Assert
            Assert.NotEmpty(list);
            Assert.Equal(1, list.Count);
            Assert.IsType<Data.Model.Vehicle>(list[0]);
            Assert.Single(list);
        }

        [Fact]
        public void Get_FilterEmpty_ReturnOk()
        {
            //Arrange
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 4,
                RegistrationNumber = "A17-E-147",
                VehicleNumber = 1,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "230.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 1,
                FuelTypeId = 1,
                VehicleTypeId = 1,
                VehicleModelId = 1
            });
            _context.SaveChanges();

            VehicleSearchRequest request = new VehicleSearchRequest();

            //Act
            var result = _vehicleService.Get(request);

            //Assert
            Assert.IsType<List<Data.Model.Vehicle>>(result);
        }

        [Fact]
        public void Delete_DeleteRow_ReturnOk()
        {
            //Arrange
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 5,
                RegistrationNumber = "A17-E-147",
                VehicleNumber = 1,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "230.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 1,
                FuelTypeId = 1,
                VehicleTypeId = 1,
                VehicleModelId = 1
            });
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 6,
                RegistrationNumber = "A22-E222",
                VehicleNumber = 2,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "195.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 2,
                FuelTypeId = 2,
                VehicleTypeId = 2,
                VehicleModelId = 2
            });
            _context.SaveChanges();

            VehicleSearchRequest request = new VehicleSearchRequest();

            //Act
            _vehicleService.Delete(6);
            var actualList = _vehicleService.Get(request);
            
            //Assert
            Assert.Equal(7, actualList.Count);
            Assert.IsType<List<Data.Model.Vehicle>>(actualList);
        }

        [Fact]
        public void Update_UpdateRegisterNumber_ReturnOk()
        {
            //Arrange
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 7,
                RegistrationNumber = "A22-E222",
                VehicleNumber = 2,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "195.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 2,
                FuelTypeId = 2,
                VehicleTypeId = 2,
                VehicleModelId = 2
            });
            _context.SaveChanges();
            
            var item = _vehicleService.GetByID(7);

            //Act
            var updatedItem = new VehicleUpsert
            {
                RegistrationNumber = "A11-A-111"
            };

            var result = _vehicleService.Update(item.VehicleId, updatedItem);
            _context.SaveChanges();

            //Assert
            Assert.Equal("A11-A-111", result.RegistrationNumber);
        }

        [Fact]
        public void GetById_ShouldGetItem_ReturnOk()
        {
            //Arrange
            _context.Vehicle.Add(new RentACar.WebAPI.Database.Vehicle
            {
                VehicleId = 8,
                RegistrationNumber = "R34-E-467",
                VehicleNumber = 2,
                DailyPrice = 90,
                Description = "Auto u super stanju",
                ManufacturerDate = DateTime.Today,
                Mileage = "195.000",
                Transmission = "Automatik",
                NumberOfSeats = 5,
                Status = false,
                BranchId = 2,
                FuelTypeId = 2,
                VehicleTypeId = 2,
                VehicleModelId = 2
            });
            _context.SaveChanges();

            //Act
            var item = _vehicleService.GetByID(8);

            //Assert
            Assert.IsType<Data.Model.Vehicle>(item);
        }
    }
}
