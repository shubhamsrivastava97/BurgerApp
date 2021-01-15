using System;
using System.Collections.Generic;
using System.Linq;
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
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersDAL _ordersDal;

        public OrdersController(IOrdersDAL ordersDal)
        {
            _ordersDal = ordersDal;
        }

        // GET: api/Orders
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return _ordersDal.GeOrders();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(string id)
        {
            var order = _ordersDal.GetOrder(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }


        // POST: api/Orders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            string response = _ordersDal.PostOrder(order);
            if (response == "Success")
            {
                return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
            }
            else
            {
                return Forbid();
            }

        }

    }
}
