using moviehub.Models.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moviehub.Models
{
    public class MovieModel
    {
        [Key]
        public int MovieId { get; set; }
        public string MoiveName { get; set; }
        public string MoiveDescription { get; set; }
        public string MoiveStartDate { get; set; }
        public string MoiveEndDate { get; set; }
        public string MoiveMovieURL { get; set; }
        public MovieCategory MovieCategory { get; set; }
        
        //relationships
        public List<ActorMovieModel> ActorMovies { get; set; }

        //Directorrelationship
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public DirectorModel Director { get; set; }

        //cinemarelationship
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public CinemaModel Cinema { get; set; }

    }
}
