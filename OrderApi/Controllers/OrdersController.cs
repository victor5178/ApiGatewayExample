using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrderApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/orders
        [HttpGet, Route("")]
        public IActionResult GetOrders()
        {
            var order1 = new Order("id1", 200);
            var order2 = new Order("order2", 400);
            return Ok(new List<Order> {order1,order2});
        }
    }

    public class Order 
    {
        public string Id {get; set;}
        public decimal Amount {get; set;}

        public Order(string id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }

    }
}
