using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiemSach.Server;
using TiemSach.Shared;
using System.Linq;

namespace TiemSach.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SachsController : ControllerBase {
        private readonly TiemSachDbContext db;
        public SachsController(TiemSachDbContext db) {
            this.db = db;
        }

        [HttpGet("/sachs")]
        public IQueryable<Sach> GetPSachs()
        => this.db.Sachs;

        [HttpPost("/sachs")]
        public IActionResult InsertSach([FromBody] Sach sach) {
            db.Sachs.Add(sach);
            db.SaveChanges();
            return Created($"sachs/{sach.Id}", sach);
        }
    }
}

