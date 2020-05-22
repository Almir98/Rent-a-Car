using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Rating;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class RatingController : BaseCRUDController<RatingRequest, RatingSearchRequest, RatingUpsert, RatingUpsert>
    {
        public RatingController(ICRUDService<RatingRequest, RatingSearchRequest, RatingUpsert, RatingUpsert> service) : base(service)
        {
        }
    }
}