using AutoMapper;
using Rent_a_Car.WebAPI.Service;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Service
{
    public class ManufacturerService : BaseService<Data.Model.Manufacturer, object, Database.Manufacturer>
    {
        public ManufacturerService(RentaCarContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
