namespace Etickets.Models
{
    public enum MovieStatus
    {
        ComingSoon,
        NowShowing,
        Ended
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImgUrl { get; set; } = string.Empty;
        public string TrailerUrl { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieStatus MovieStatus { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; } = default!;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
