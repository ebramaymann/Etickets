using Etickets.Models;

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

        public List<Cinema> Cinemas { get; set; } = new List<Cinema>();
        public Cinema Cinema { get; set; } = default!;
        public List<Category> Categories { get; set; } = new List<Category>();


        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<ActorMovie>? ActorMovies { get; set; }

    }
}
