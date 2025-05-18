using Etickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace Etickets.Areas.Customer.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
