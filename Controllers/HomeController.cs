using Microsoft.AspNetCore.Mvc;
using Resto_practice.DAL;

namespace Resto_practice.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
