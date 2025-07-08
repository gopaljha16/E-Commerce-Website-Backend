using ECommerceBackendAPI.Data;
using ECommerceBackendAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return Ok(orders);
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Ok(order);
        }
    }
}
