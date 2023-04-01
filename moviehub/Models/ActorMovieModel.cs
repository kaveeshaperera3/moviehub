namespace moviehub.Models
{
    public class ActorMovieModel
    {
        public int MovieId { get; set; }
        public MovieModel Movie { get; set; }   
        public int ActorId { get; set; }
        public ActorModel Actor { get; set; }   


    }
}
