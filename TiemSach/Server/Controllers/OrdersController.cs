using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiemSach.Shared;
using System.Linq;
namespace TiemSach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly TiemSachDbContext db;
        public OrdersController(TiemSachDbContext db)
        {
            this.db = db;
        }
        [HttpPost("/orders")]
        public IActionResult InsertOrder([FromBody] ShoppingBasket basket)
        {
            Order order = new Order();
            order.Customer = basket.Customer;
            order.Sachs = new List<Sach>();
            foreach (int sachId in basket.Orders)
            {
                var sach = db.Sachs.Single(p => p.Id == sachId);
            }
            db.Orders.Add(order);
            db.SaveChanges();
            return Created("/orders", order.Id);
        }
    }
}
