using Etickets.Areas.Customer.Controllers;
using Etickets.Data;
using Etickets.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Etickets.Areas.Admin.Controllers
{
    public class MoviesController : Controller
    {
       

        
        private readonly ApplicationDbContext _context = new();

      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {


            CreateMovieFormVM createMovieFormVM = new()
            {
                //Cinemas = _context.Cinemas.Select(c => new SelectListItem
                //{
                //    Text = c.Name,
                //    Value = c.Id.ToString()
                //}).ToList(),
                Categories = _context.Categories
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                })
                .OrderBy(c => c.Text)
                .ToList()

            };

            return View(createMovieFormVM);
        }
    }
}
