namespace Etickets.Models
{
    public class ActorMovie
    {
        public int ActorsId { get; set; }
        public Actor Actor { get; set; } = default!;

        public int MoviesId { get; set; }
        public Movie Movie { get; set; } = default!;
    }
}
