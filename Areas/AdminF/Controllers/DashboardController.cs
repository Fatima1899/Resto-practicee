using Microsoft.AspNetCore.Mvc;

namespace Resto_practice.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
