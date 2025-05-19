using Etickets.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Etickets.Models.ViewModels
{
    public class CreateMovieFormVM
    {

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public IFormFile ImgUrl { get; set; } = default!;
        public string TrailerUrl { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieStatus MovieStatus { get; set; }

        public int CinemaId { get; set; }

        //public List<Cinema> Cinemas { get; set; } = new List<Cinema>();
        public Cinema Cinema { get; set; } = default!;

        [Display(Name = "Category" )]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        //public List<Category> Categories { get; set; } = new List<Category>();
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> Cinemas { get; set; } = Enumerable.Empty<SelectListItem>();

         
        public IEnumerable<SelectListItem> Actors { get; set; } = Enumerable.Empty<SelectListItem>();


        public ICollection<ActorMovie>? ActorMovies { get; set; }

    }
}
