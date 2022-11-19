using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ServiceController : Controller
    {
        private readonly BizLandDbContext _context;
        public ServiceController(BizLandDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id=1)
        {
            Service service = _context.Services.ToList().Find(x => x.Id == id);
            return View(service);
        }
    }
}
