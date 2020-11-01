using AutoMapper;
using Helper;
using Microsoft.EntityFrameworkCore;
using RentaCar.Data.Requests.Customer;
using RentACar.WebAPI.Database;
using RentACar.WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RentACar.WebAPI.Service
{
    public class CustomerService : ICustomerService
    {
        protected readonly RentaCarContext _context;
        protected readonly IMapper _mapper;

        public CustomerService(RentaCarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Data.Model.Customer> Get(CustomerSearchRequest request)
        {
            var query = _context.Customer.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.FirstName))
            {
                query = query.Where(x => x.FirstName.StartsWith(request.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(request.LastName))
            {
                query = query.Where(x => x.LastName.StartsWith(request.LastName));
            }
          
            if (!string.IsNullOrWhiteSpace(request.Phone))
            {
                query = query.Where(x => x.Phone.StartsWith(request.Phone));
            }

            if (!string.IsNullOrWhiteSpace(request.Email))
            {
                query = query.Where(x => x.Email.StartsWith(request.Email));
            }

            if (!string.IsNullOrWhiteSpace(request.Username))
            {
                query = query.Where(x => x.Username == request.Username);
            }


            // DODANO FILTIRANJE NA APIJU
            if (request.CustomerTypeId.HasValue == true)
            {
                query = query.Where(x => x.CustomerTypeId == request.CustomerTypeId);
            }

            return _mapper.Map<List<Data.Model.Customer>>(query.ToList());
        }

        public Data.Model.Customer Insert(CustomerUpsert request)
        {
            var entity = _mapper.Map<Customer>(request);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password and password confirm not matched !");
            }
            entity.PasswordSalt = HashGenerator.GenerateSalt();
            entity.PasswordHash = HashGenerator.GenerateHash(entity.PasswordSalt, request.Password);

            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.Customer>(entity);
        }

        public Data.Model.Customer Update(int id, CustomerUpsert request)
        {
            var entity = _context.Customer.Find(id);

            _context.Customer.Attach(entity);
            _context.Customer.Update(entity);

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Data.Model.Customer>(entity);
        }

        public Data.Model.Customer Authenticate(CustomerLoginRequest request)
        {
            var customer = _context.Customer.Include(e=>e.CustomerType).FirstOrDefault(x => x.Username == request.Username);

            if (customer != null)
            {
                var newHash = HashGenerator.GenerateHash(customer.PasswordSalt, request.Password);

                if (customer.PasswordHash == newHash)
                {
                    return _mapper.Map<Data.Model.Customer>(customer);
                }
            }
            return null;
        }

        public Data.Model.Customer GetById(int id)
        {
            var customer = _context.Customer.Include(a => a.City).FirstOrDefault(x => x.CustomerId == id);
            return _mapper.Map<Data.Model.Customer>(customer);
        }
    }
}
