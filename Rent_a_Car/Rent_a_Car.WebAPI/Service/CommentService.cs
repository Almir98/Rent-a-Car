using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Rent_a_Car.WebAPI.Database;
using Rent_a_Car.WebAPI.Models;
using RentaCar.Data.Requests.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class CommentService : BaseCRUDService<MComment, CommentSearchRequest, Comment, CommentUpsert, CommentUpsert>
    {
        public CommentService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MComment> Get(CommentSearchRequest search)
        {
            var query = _context.Comment.Include(x=>x.Customer)
                .Include(x=>x.Vehicle)
                .Include(x=>x.Vehicle.VehicleModel)
                .Include(x=>x.Vehicle.VehicleModel.Manufacturer)
                .AsQueryable();

            if(!string.IsNullOrEmpty(search.CustomerFirstName))
            {
                query = query.Where(x => x.Customer.FirstName == search.CustomerFirstName);
            }
            
            if(!string.IsNullOrEmpty(search.ManufacturerName))
            {
                query = query.Where(x => x.Vehicle.VehicleModel.Manufacturer.ManufacturerName == search.ManufacturerName);
            }

            var lista = query.ToList();

            return _mapper.Map<List<MComment>>(lista);
        }

        //    var listComments = _context.Comment.ToList();
        //    var listCustomer = _context.Customer.ToList();
        //    var listVehicle = _context.Vehicle.ToList();
        //    var listVehicleModel = _context.VehicleModel.ToList();
        //    var listManufacturer = _context.Manufacturer.ToList();

        //    List<MoComment> output = new List<MoComment>();

        //    foreach (var comment in listComments)
        //    {
        //        foreach (var customer in listCustomer)
        //        {
        //            if(comment.CustomerId==customer.CustomerId)
        //            {
        //                foreach (var vehicle in listVehicle)
        //                {
        //                    if(comment.VehicleId==vehicle.VehicleId)
        //                    {
        //                        foreach (var vehicleModel in listVehicleModel)
        //                        {
        //                            if(vehicle.VehicleModelId==vehicleModel.ModelId)
        //                            {
        //                                foreach (var manufacturer in listManufacturer)
        //                                {
        //                                    if(vehicleModel.ManufacturerId==manufacturer.ManufacturerId)
        //                                    {
        //                                        MoComment temp = new MoComment
        //                                        {
        //                                            CommentId=comment.CommentId,
        //                                            Description=comment.Description,
        //                                            DateOfComment=comment.DateOfComment,

        //                                            CustomerId=customer.CustomerId,
        //                                            VehicleId=vehicle.VehicleId,
        //                                            VehicleModelId=vehicleModel.ModelId,
        //                                            ManufacturerId=manufacturer.ManufacturerId,

        //                                            FirstName=customer.FirstName,
        //                                            LastName=customer.LastName,
        //                                            ManufacturerName=manufacturer.ManufacturerName,
        //                                            ModelName=vehicleModel.ModelName
        //                                        };
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }






    }
}
