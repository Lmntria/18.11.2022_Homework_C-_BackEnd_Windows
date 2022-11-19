using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication2.Models;
using WebApplication2.DAL;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly BizLandDbContext _context;
        public HomeController(BizLandDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            HomeVM vm = new HomeVM
            {
                Features = _context.Features.ToList(),
                Services=_context.Services.ToList(),
                Tests= _context.Tests.ToList(),
                Portfolios= _context.Portfolios.ToList(),
                Teams=_context.Teams.ToList(),
                Prices=_context.Prices.ToList(),
            };
            return View(vm);
        }
    }
}
