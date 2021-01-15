using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BurgerApp.Models;

namespace BurgerApp.DAL
{
    public interface IOrdersDAL
    {
        IEnumerable<Order> GeOrders();
        Order GetOrder(string id);
        string PostOrder(Order order);
    }

    public class OrderDAL : IOrdersDAL
    {
        private readonly reactmyburgerContext _context;

        public OrderDAL(reactmyburgerContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GeOrders()
        {
            return _context.Orders;
        }

        public Order GetOrder(string id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }

        public string PostOrder(Order order)
        {
            _context.Orders.Add(order);
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
