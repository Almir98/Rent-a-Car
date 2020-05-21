//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Rent_a_Car.WebAPI.Exceptions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Threading.Tasks;

//namespace Rent_a_Car.WebAPI.Filters
//{
//    public class ErrorFilter: ExceptionFilterAttribute
//    {
//        public override void OnException(ExceptionContext context)
//        {
//            if (context.Exception is UserException)
//            {
//                context.ModelState.AddModelError("ERROR", context.Exception.Message);                       // Client Exception
//                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
//            }
//            else
//            {
//                context.ModelState.AddModelError("ERROR", "Greška na serveru");                             // Server Exception
//                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
//            }

//            var list = context.ModelState.Where(x => x.Value.Errors.Count > 0).ToDictionary(x => x.Key, y => y.Value.Errors.Select(z => z.ErrorMessage));
            
//            context.Result = new JsonResult(list);
//        }
//    }
//}
