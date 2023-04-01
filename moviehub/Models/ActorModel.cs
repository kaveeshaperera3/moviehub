using System.ComponentModel.DataAnnotations;

namespace moviehub.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorDescription { get; set; }
        public string ActorProfilePicURL { get; set; }

        //relationships
        public List<ActorMovieModel> ActorMovies { get; set; }
    }
}
