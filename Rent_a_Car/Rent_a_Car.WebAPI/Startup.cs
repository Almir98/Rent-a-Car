using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Rent_a_Car.WebAPI.Filters;
using Rent_a_Car.WebAPI.Interface;
using Rent_a_Car.WebAPI.Service;
using RentaCar.Data.Requests.Booking;
using RentaCar.Data.Requests.Branch;
using RentaCar.Data.Requests.City;
using RentaCar.Data.Requests.Comments;
using RentaCar.Data.Requests.Manufacturer;
using RentaCar.Data.Requests.Rating;
using RentaCar.Data.Requests.Vehicle;
using RentaCar.Data.Requests.VehicleModel;
using RentaCar.Data.Requests.VehicleType;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Interface;
using RentACar.WebAPI.Security;
using RentACar.WebAPI.Service;

namespace Rent_a_Car.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.Filters.Add<ErrorFilter>());        

            services.AddControllers();

            
            services.AddDbContext<RentaCarContext>(c => c.UseSqlServer(Configuration.GetConnectionString("RentaCarCS"))
            .EnableSensitiveDataLogging());    

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RentACar API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddAutoMapper(typeof(Startup));                //Automapper configuration

            #region Dependency injection

            services.AddScoped<IService<Data.Model.FuelType, object>, BaseService<Data.Model.FuelType, object, RentACar.WebAPI.Database.FuelType>>();
            services.AddScoped<IService<VehicleTypeRequest, object>, BaseService<VehicleTypeRequest, object, RentACar.WebAPI.Database.VehicleType>>();
            services.AddScoped<IService<Data.Model.VehicleModel, VehicleModelSearch>, VehicleModelService>();
            services.AddScoped<IService<Data.Model.City, CitySearchRequest>, CityService>();
            services.AddScoped<IService<Data.Model.Manufacturer, object>, BaseService<Data.Model.Manufacturer, object, RentACar.WebAPI.Database.Manufacturer>>();
            
            services.AddScoped<ICRUDService<Data.Model.Branch, BranchSearchRequest, BranchUpsert, BranchUpsert>, BranchService>();
            services.AddScoped<ICRUDService<Data.Model.Vehicle, VehicleSearchRequest, VehicleUpsert, VehicleUpsert>, VehicleService>();
            services.AddScoped<ICRUDService<Data.Model.Booking, BookingSearchRequest, BookingUpsert, BookingUpsert>, BookingService>();
            services.AddScoped<ICRUDService<Data.Model.Rating, RatingSearchRequest, RatingUpsert, RatingUpsert>, RatingService>();
            services.AddScoped<ICRUDService<Data.Model.Comment, CommentSearchRequest, CommentUpsert, CommentUpsert>, CommentService>();
            
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IRecommendService,RecommendService>();

            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
