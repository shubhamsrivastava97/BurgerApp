using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BurgerApp.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BurgerApp.Models;

namespace BurgerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersDAL _customersDal;

        public CustomersController(ICustomersDAL customersDal)
        {
            _customersDal = customersDal;
        }

        // GET: api/Customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customersDal.GetCustomers();
        }

        // GET: api/Customers/id
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(string id)
        {
            var customer = _customersDal.GetCustomer(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }


        // POST: api/Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {
            string response = _customersDal.PostCustomer(customer);

            if (response == "Success")
            {
                return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
            }
            else
            {
                return Forbid();
            }

        }


    }
}
