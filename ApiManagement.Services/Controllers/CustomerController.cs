using ApiManagement.Services.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ApiManagement.Services.Controllers
{
    public class CustomerController : ApiController
    {
        public List<Customer> Get()
        {
            return new List<Customer>
            {
                new Customer { Id = Guid.NewGuid(), FirstName = "Arjen", LastName = "Robben" },
                new Customer { Id = Guid.NewGuid(), FirstName = "Lionel", LastName = "Messi" },
                new Customer { Id = Guid.NewGuid(), FirstName = "Cristiano", LastName = "Ronaldo" }
            };
        }
    }
}
