using Microsoft.EntityFrameworkCore;
using RentACar.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI
{
    public class SetupService
    {
        public static void Seed(RentaCarContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
