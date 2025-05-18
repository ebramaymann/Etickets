using Etickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace Etickets.Areas.Admin.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();


       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
