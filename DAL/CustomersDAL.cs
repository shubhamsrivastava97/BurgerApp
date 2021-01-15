using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;

namespace BurgerApp.DAL
{
    public interface ICustomersDAL
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(string id);
        string PostCustomer(Customer customer);
    }

    public class CustomersDAL : ICustomersDAL
    {
        //persistence context
        private readonly reactmyburgerContext _context;

        //Constructor
        public CustomersDAL(reactmyburgerContext context)
        {
            _context = context;
        }


        //Get customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomer(string id)
        {
           Customer customer = _context.Customers.Find(id);
           return customer;
        }

        public string PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            try
            {
                _context.SaveChanges();
                return "Success";
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        //Disposing
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            };
        }
    }
}
