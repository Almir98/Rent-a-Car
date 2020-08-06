using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Rating;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    public class RatingController : BaseCRUDController<Data.Model.Rating, RatingSearchRequest, RatingUpsert, RatingUpsert>
    {
        public RatingController(ICRUDService<Rating, RatingSearchRequest, RatingUpsert, RatingUpsert> service) : base(service)
        {
        }
    }
}