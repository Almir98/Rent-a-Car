using Data.Model;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Data.Requests.Comments;
using RentACar.WebAPI.Interface;

namespace RentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : BaseCRUDController<Data.Model.Comment, CommentSearchRequest, CommentUpsert, CommentUpsert>
    {
        public CommentController(ICRUDService<Comment, CommentSearchRequest, CommentUpsert, CommentUpsert> service) : base(service)
        {
        }
    }
}